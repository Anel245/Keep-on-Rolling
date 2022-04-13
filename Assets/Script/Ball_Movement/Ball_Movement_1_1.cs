using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball_Movement_1_1 : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
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

    private Ball_Controlls controlls;

    private void Awake()
    {
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

        // Ball movement

        Cam_rotation = Cam.transform.rotation.eulerAngles.y;
        Cam_Quat = Quaternion.Euler(0f, Cam_rotation, 0f);
        Input_Direction = new Vector3(Horizontal_Input, 0f, Vertical_Input).normalized;
        if (Ball_RB.velocity.magnitude <= Max_Velocity)
        {
            Ball_RB.AddForce(Cam_Quat * Input_Direction * Speed);
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
            Ball_RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void OnLookaround(InputAction.CallbackContext context)
    {

    }

    public void OnCamera(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
