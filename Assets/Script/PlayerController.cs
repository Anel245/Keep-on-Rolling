using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;

    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);  
    }












    //public float speed = 6f;


    //void FixedUpdate()
    //{

    //    //moving
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.position += Vector3.forward * Time.deltaTime * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.position += Vector3.back * Time.deltaTime * speed;
    //    }

    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.position += Vector3.left * Time.deltaTime * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.position += Vector3.right * Time.deltaTime * speed;
    //    }
    //}
}
