using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using MoreMountains.Feedbacks;

public class Ball_Movement_1_4 : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{
    private Rigidbody RB;
    private Vector3 Input_Direction;
    private float Horizontal_Input;
    private float Vertical_Input;

    [Header("Ball Values")]
    public float BallSpeed;
    public float GravityScale;
    public float BallAirSpeedControl;
    private float BallGroundSpeed;
    private float BallAirSpeed;
    public float BalljumpForce;
    private float BallGroundDrag;
    private float BallAirDrag;
    public float BallAirDragRate;
    public GameObject Trail;
    public float GroundcheckLength;

    private bool Grounded;


    [Header("Camera")]
    public Camera Cam;
    private float Cam_rotation;
    private Quaternion Cam_Quat;
    public CinemachineFreeLook CineCamera;
    public float SmoothTime;
    float CameraFOVVelocity;
    private Vector2 XZVelocity;

    private Ball_Controlls controlls;

    [Header("Feddbacks")]
    public MMF_Player jumpFeedback;

    private void Awake()
    {
        Cursor.visible = false;

        //Get Rigidbody & Camera
        RB = this.GetComponent<Rigidbody>();
        Cam = Camera.main;
        CineCamera = FindObjectOfType<CinemachineFreeLook>();
        SetMouseSensitivity();


        //Setting private Ball Movement Values
        BallGroundSpeed = BallSpeed;
        BallAirSpeed = BallGroundSpeed * BallAirSpeedControl;
        BallGroundDrag = RB.drag;
        BallAirDrag = BallGroundDrag * BallAirDragRate;


        //Get controller
        if (controlls == null)
        {
            controlls = new Ball_Controlls();
            controlls.Enable();
            controlls.Ball_Controls.SetCallbacks(this);
        }
    }


    void FixedUpdate()
    {
        //Apply Gravity
        Vector3 Gravity = Vector3.down * 9.81f * GravityScale;
        RB.AddForce(Gravity, ForceMode.Acceleration);

        // Is the ball grounded, switching between Airspeed and Groundspeed, switching between Airdrag and Grounddrag

        if (Physics.Raycast(transform.position, Vector3.down, GroundcheckLength))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Grounded == true)
        {
            BallSpeed = BallGroundSpeed;
            RB.drag = BallGroundDrag;
        }
        else
        {
            BallSpeed = BallAirSpeed;
            RB.drag = BallAirDrag;
        }

        // FOV changes
        XZVelocity = new Vector2(RB.velocity.x, RB.velocity.z);
        CineCamera.m_Lens.FieldOfView = 35 + Mathf.SmoothDamp(0, XZVelocity.magnitude, ref CameraFOVVelocity, SmoothTime) * 4;


        // Ball movement

        Cam_rotation = Cam.transform.rotation.eulerAngles.y;
        Cam_Quat = Quaternion.Euler(0f, Cam_rotation, 0f);
        Input_Direction = new Vector3(Horizontal_Input, 0f, Vertical_Input).normalized;
        RB.AddForce(Cam_Quat * Input_Direction * BallSpeed);
    }

    public void SetMouseSensitivity()
    {
        CineCamera.m_XAxis.m_MaxSpeed = PlayerPrefs.GetFloat("XMouseSensitivity") * 100;
        CineCamera.m_YAxis.m_MaxSpeed = PlayerPrefs.GetFloat("YMouseSensitivity");
    }

    // Inputs

    public void OnMovement(InputAction.CallbackContext context)
    {
        Horizontal_Input = context.ReadValue<Vector2>().x;
        Vertical_Input = context.ReadValue<Vector2>().y;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (Grounded == true && context.started)
        {
            RB.AddForce(Vector3.up * BalljumpForce, ForceMode.Impulse);
            jumpFeedback.PlayFeedbacks();
        }
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {

    }

    public void OnPauseMenu(InputAction.CallbackContext context)
    {
    }
}