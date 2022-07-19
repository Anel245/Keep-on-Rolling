using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Booster_v_1_1 : MonoBehaviour
{
    public float Boostforce;
    public Vector3 Boostdirection;
    private Rigidbody Player_RB;

    public bool active;

    private void OnTriggerEnter(Collider other)
    {
        Player_RB = other.GetComponent<Rigidbody>();
        Player_RB.AddForce(Boostforce * Vector3.forward, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        active = true;
        Player_RB = collision.gameObject.GetComponent<Rigidbody>();
        //Player_RB.velocity = Boostforce * transform.TransformDirection(Vector3.forward);
        //Player_RB.AddForce(Boostforce * transform.TransformDirection(Vector3.forward), ForceMode.Impulse);
    }

    private void OnCollisionExit(Collision collision)
    {
        active = false;
    }

    private void Update()
    {

        if (active)
        {
            Player_RB.velocity = Boostforce * transform.TransformDirection(Vector3.forward);
        }
    }
}
