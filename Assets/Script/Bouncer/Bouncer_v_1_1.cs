using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Bouncer_v_1_1 : MonoBehaviour
{
    public float Bounceforce;
    public float KeepVelocity;

    private Rigidbody Player_RB;
    private Vector3 BounceDirection;

    public GameObject Player;

    private void Update()
    {
        transform.LookAt(new Vector3(Player.transform.position.x,transform.position.y,Player.transform.position.z));
    }

    private void OnTriggerEnter(Collider other)
    {
        Player_RB = other.GetComponent<Rigidbody>();
        BounceDirection = Player_RB.velocity.normalized + ((other.transform.position - transform.position).normalized * 1.4f); 
        Player_RB.AddForce(BounceDirection.normalized * ((Player_RB.velocity.magnitude * KeepVelocity) +1) * Bounceforce, ForceMode.Impulse);
    }
}
