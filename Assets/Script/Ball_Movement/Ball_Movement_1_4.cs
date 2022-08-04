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
    public bool Dead;


    [Header("Camera")]
    public Camera Cam;
    private float Cam_rotation;
    private Quaternion Cam_Quat;
    public CinemachineFreeLook CineCamera;
    public float SmoothTime;
    float CameraFOVVelocity;
    private Vector2 XZVelocity;

    private Ball_Controlls controlls;

    //FMOD
    private AudioManager audioManager;
    public bool RollingPlaying = false;
    public float MaxSpeed = 60f;

    [Header("Feedbacks")]
    public MMF_Player jumpFeedback;
    public MMF_Player sausageCollisionFeedback;
    public MMF_Player landingFeedback;
    public GameObject dustTrail;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

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
    private void Start()
    {
        //FMOD
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
            audioManager.BallRollingInitialize(transform, RB);
        }
    }

    void FixedUpdate()
    {
        //Apply Gravity
        Vector3 Gravity = Vector3.down * 9.81f * GravityScale;
        RB.AddForce(Gravity, ForceMode.Acceleration);

        // Is the ball grounded, switching between Airspeed and Groundspeed, switching between Airdrag and Grounddrag

        if (Physics.Raycast(transform.position + new Vector3(0.7f, 0, 0.7f), Vector3.down, GroundcheckLength) || Physics.Raycast(transform.position + new Vector3(-0.7f, 0, 0.7f), Vector3.down, GroundcheckLength) || Physics.Raycast(transform.position + new Vector3(-0.7f, 0, -0.7f), Vector3.down, GroundcheckLength) || Physics.Raycast(transform.position + new Vector3(0.7f, 0, -0.7f), Vector3.down, GroundcheckLength))
        {
            if (Grounded == false)
            {
                landingFeedback.PlayFeedbacks();
            }
            Grounded = true;
            dustTrail.gameObject.transform.position = this.gameObject.transform.position;
            dustTrail.gameObject.transform.position += new Vector3(0, -0.6f, 0);
            dustTrail.gameObject.SetActive(true);
            //dustTrail.gameObject.transform.position.y = -0.5;

        }
        else
        {
            Grounded = false;
            dustTrail.gameObject.SetActive(false);
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

        //FMOD RollSound
        if (Grounded == true && RB.velocity.magnitude > 0 && RollingPlaying == false)
        {
            audioManager.BallRollingStart(transform, RB);
            RollingPlaying = true;
        }
        if ((Grounded == false && RollingPlaying == true) || (RB.velocity.magnitude == 0 && RollingPlaying == true))
        {
            audioManager.BallRollingStop();
            RollingPlaying = false;
        }
        if (RollingPlaying == true)
        {
            audioManager.BallRollingSpeedUpdate(Mathf.Clamp((RB.velocity.magnitude/MaxSpeed),0f,1f));
        }
    }

    public void SetMouseSensitivity()
    {
        CineCamera.m_XAxis.m_MaxSpeed = PlayerPrefs.GetFloat("XMouseSensitivity") * 100;
        CineCamera.m_YAxis.m_MaxSpeed = PlayerPrefs.GetFloat("YMouseSensitivity");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //audioManager.BallImpact(transform.position);
        if (collision.gameObject.tag == "Sausage")
        {
            sausageCollisionFeedback.PlayFeedbacks(collision.contacts[0].point);
        }
    }

    // Inputs

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (Dead == false)
        {
            Horizontal_Input = context.ReadValue<Vector2>().x;
            Vertical_Input = context.ReadValue<Vector2>().y;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (Grounded == true && context.started && Dead == false)
        {
            RB.AddForce(Vector3.up * BalljumpForce, ForceMode.Impulse);
            jumpFeedback.PlayFeedbacks();
            audioManager.Jump(transform.position);
        }
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {

    }

    public void OnPauseMenu(InputAction.CallbackContext context)
    {
    }
}