using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class Ball_Movement_1_2 : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{
    private Rigidbody Ball_RB;
    private Vector3 Input_Direction;
    public float Max_Velocity = 10f;
    private float Horizontal_Input;
    private float Vertical_Input;

    public float Speed = 60f;
    public float AirSpeedControl = 0.5f;
    private float GroundSpeed;
    private float AirSpeed;

    private bool Grounded;
    private float Colliding_Objects;
    private float GroundDrag;
    private float AirDrag;
    public float AirDragRate;

    public float jumpForce = 10f;

    public Camera Cam;
    private float Cam_rotation;
    private Quaternion Cam_Quat;
    public CinemachineFreeLook CineCamera;

    private Ball_Controlls controlls;

    //Switch
    private bool BallForm;
    public MeshFilter meshfilter;
    public Mesh CatMesh;
    public Mesh CubeMesh;
    public Collider BallCol;
    public Collider CubeCol;

    private void Awake()
    {
        BallForm = true;
        Cam = Camera.main;
        GroundSpeed = Speed;
        AirSpeed = GroundSpeed * AirSpeedControl;
        Ball_RB = this.GetComponent<Rigidbody>();
        GroundDrag = Ball_RB.drag;
        AirDrag = GroundDrag * AirDragRate;

        if (controlls == null)
        {
            controlls = new Ball_Controlls();
            controlls.Enable();
            controlls.Ball_Controls.SetCallbacks(this);
        }
    }

    void FixedUpdate()
    {
        // Is the ball grounded, switching between Airspeed and Groundspeed, switching between Airdrag and Grounddrag

        if (Colliding_Objects > 0)
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Grounded == true)
        {
            Speed = GroundSpeed;
            Ball_RB.drag = GroundDrag;
        }
        else
        {
            Speed = AirSpeed;
            Ball_RB.drag = AirDrag;
        }

        CineCamera.m_Lens.FieldOfView = 35 + Ball_RB.velocity.magnitude*1.5f;

        // Ball movement

        Cam_rotation = Cam.transform.rotation.eulerAngles.y;
        Cam_Quat = Quaternion.Euler(0f, Cam_rotation, 0f);
        Input_Direction = new Vector3(Horizontal_Input, 0f, Vertical_Input).normalized;
        Ball_RB.AddForce(Cam_Quat * Input_Direction * Speed);
        if (Ball_RB.velocity.magnitude > Max_Velocity)
        {
            Ball_RB.velocity = Vector3.ClampMagnitude(Ball_RB.velocity, Max_Velocity);
        }


    }

    // Is the ball grounded

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            Colliding_Objects += 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            Colliding_Objects -= 1;
        }
    }

    // Inputs

    public void OnMovement(InputAction.CallbackContext context)
    {
        Horizontal_Input = context.ReadValue<Vector2>().x;
        Vertical_Input = context.ReadValue<Vector2>().y;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (Grounded == true)
        {
            Ball_RB.AddForce(Vector3.up * jumpForce);
        }
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {

    }

    public void OnSwitch(InputAction.CallbackContext context)
    {
        if(BallForm == true)
        {
            meshfilter.mesh = CubeMesh;
            CubeCol.enabled = true;
            BallCol.enabled = false;
            BallForm = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Ball_RB.freezeRotation = true;
        }
        else
        {
            meshfilter.mesh = CatMesh;
            BallCol.enabled = true;
            CubeCol.enabled = false;
            BallForm = true;
            Ball_RB.constraints = RigidbodyConstraints.None;
        }
    }

    public void OnPauseMenu(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
