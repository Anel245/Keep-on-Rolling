using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster_v_1_1 : MonoBehaviour
{
    public float Boostforce;
    public Vector3 Boostdirection;
    private Rigidbody Player_RB;



    private void OnTriggerEnter(Collider other)
    {
        Player_RB = other.GetComponent<Rigidbody>();
        Player_RB.AddForce(Boostdirection * Boostforce, ForceMode.Impulse);
    }
}
