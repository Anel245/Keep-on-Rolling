using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class Ball_Movement_1_3 : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{
    private Rigidbody Ball_RB;
    private Vector3 Input_Direction;
    private float Horizontal_Input;
    private float Vertical_Input;

    [Header("Ball Values")]
    public float  BallSpeed;
    public float  BallAirSpeedControl;
    private float BallGroundSpeed;
    private float BallAirSpeed;
    public float  BalljumpForce;
    private float BallGroundDrag;
    private float BallAirDrag;
    public float  BallAirDragRate;

    [Header("Cat Values")]
    public float CatSpeed;
    public float CatAirSpeedControl;
    private float CatGroundSpeed;
    private float CatAirSpeed;
    public float CatjumpForce;
    private float CatGroundDrag;
    private float CatAirDrag;
    public float CatAirDragRate;

    private float Speed;
    private float AirSpeedControl;
    private float GroundSpeed;
    private float AirSpeed;
    private float jumpForce;
    private float GroundDrag;
    private float AirDrag;
    private float AirDragRate;

    private bool Grounded;
    private float Colliding_Objects;


    [Header("Camera")]
    public Camera Cam;
    private float Cam_rotation;
    private Quaternion Cam_Quat;
    public CinemachineFreeLook CineCamera;
    public float SmoothTime;
    float CameraFOVVelocity;
    private Vector2 XZVelocity;


    [Header("Switch")]
    public MeshFilter meshfilter;
    public Mesh CatMesh;
    public Mesh BallMesh;
    public Collider BallCol;
    public Collider CatCol;
    private bool BallForm;

    private Ball_Controlls controlls;

    private void Awake()
    {
        BallForm = true;
        Cursor.visible = false;

        //Get Rigidbody & Camera
        Ball_RB = this.GetComponent<Rigidbody>();
        Cam = Camera.main;
        CineCamera = FindObjectOfType<CinemachineFreeLook>();


        //Setting private Ball Movement Values
        BallGroundSpeed = BallSpeed;
        BallAirSpeed = BallGroundSpeed * BallAirSpeedControl;
        BallGroundDrag = Ball_RB.drag;
        BallAirDrag = BallGroundDrag * BallAirDragRate;

        //Setting private Cat Movement Values
        CatGroundSpeed = CatSpeed;
        CatAirSpeed = CatGroundSpeed * CatAirSpeedControl;
        CatGroundDrag = Ball_RB.drag * 3;
        CatAirDrag = CatGroundDrag * CatAirDragRate;

        //Setting Current Movement
        Speed = BallSpeed;
        AirSpeedControl = BallAirSpeedControl;
        GroundSpeed = BallGroundSpeed;
        AirSpeed = BallAirSpeed;
        jumpForce = BalljumpForce;
        GroundDrag = BallGroundDrag;
        AirDrag = BallAirDrag;
        AirDragRate = BallAirDragRate;

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

        // FOV changes
        XZVelocity = new Vector2(Ball_RB.velocity.x, Ball_RB.velocity.z);
        CineCamera.m_Lens.FieldOfView = 35 + Mathf.SmoothDamp(0, XZVelocity.magnitude, ref CameraFOVVelocity, SmoothTime) * 4;


        // Ball movement
        
        Cam_rotation = Cam.transform.rotation.eulerAngles.y;
        Cam_Quat = Quaternion.Euler(0f, Cam_rotation, 0f);
        Input_Direction = new Vector3(Horizontal_Input, 0f, Vertical_Input).normalized;
        Ball_RB.AddForce(Cam_Quat * Input_Direction * Speed);

    }

    // Is the ball grounded

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Colliding_Objects -= 1;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Colliding_Objects += 1;
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
            Ball_RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {

    }

    public void OnSwitch(InputAction.CallbackContext context)
    {
        if(BallForm == true)
        {
            meshfilter.mesh = CatMesh;
            CatCol.enabled = true;
            BallCol.enabled = false;
            BallForm = false;
            Ball_RB.freezeRotation = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);

            //Switch to Cat movement values
            Speed = CatSpeed;
            AirSpeedControl = CatAirSpeedControl;
            GroundSpeed = CatGroundSpeed;
            AirSpeed = CatAirSpeed;
            jumpForce = CatjumpForce;
            GroundDrag = CatGroundDrag;
            AirDrag = CatAirDrag;
            AirDragRate = CatAirDragRate;

        }
        else
        {
            meshfilter.mesh = BallMesh;
            BallCol.enabled = true;
            CatCol.enabled = false;
            BallForm = true;
            Ball_RB.constraints = RigidbodyConstraints.None;

            //Switch to Ball movement values
            Speed = BallSpeed;
            AirSpeedControl = BallAirSpeedControl;
            GroundSpeed = BallGroundSpeed;
            AirSpeed = BallAirSpeed;
            jumpForce = BalljumpForce;
            GroundDrag = BallGroundDrag;
            AirDrag = BallAirDrag;
            AirDragRate = BallAirDragRate;
        }
    }
}
