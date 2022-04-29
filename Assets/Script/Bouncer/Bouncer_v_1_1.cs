using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Bouncer_v_1_1 : MonoBehaviour
{
    public float Bounceforce;

    private Rigidbody Player_RB;
    private Vector3 PlayerMoveDirection;

    private void OnTriggerEnter(Collider other)
    {
        Player_RB = other.GetComponent<Rigidbody>();
        PlayerMoveDirection = Player_RB.velocity;
        Player_RB.AddForce(-PlayerMoveDirection * Bounceforce, ForceMode.Impulse);
    }
}
