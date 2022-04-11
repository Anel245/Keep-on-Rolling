using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball_Movement : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{
    private Rigidbody Ball_RB;
    public Vector3 Movement_Direction;
    public float Max_Velocity;
    private float Horizontal_Input;
    private float Vertical_Input;
    public float Ball_Velocity;

    public float Speed;
    public float AirSpeedControl;
    private float GroundSpeed;
    private float AirSpeed;

    public bool Grounded;
    private float Colliding_Objects;

    public Vector3 jump;
    public float jumpForce = 2.0f;

    private Ball_Controlls controlls;

    private void Awake()
    {
        GroundSpeed = Speed;
        AirSpeed = GroundSpeed * AirSpeedControl;
        Ball_RB = this.GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        if (controlls == null)
        {
            controlls = new Ball_Controlls();
            controlls.Enable();
            controlls.Ball_Controls.SetCallbacks(this);
        }
    }
    void FixedUpdate()
    {
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
        }
        else
        {
            Speed = AirSpeed;
        }

        Ball_Velocity = Ball_RB.velocity.magnitude;
        Movement_Direction = new Vector3(Horizontal_Input, 0, Vertical_Input);
        Movement_Direction.Normalize();
        if (Ball_RB.velocity.magnitude <= Max_Velocity)
        {
            Ball_RB.AddForce(Movement_Direction * Speed);
        }
    }

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

    public void OnMovement(InputAction.CallbackContext context)
    {
        Horizontal_Input = context.ReadValue<Vector2>().x;
        Vertical_Input = context.ReadValue<Vector2>().y;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (Grounded == true)
        {
            Ball_RB.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
}