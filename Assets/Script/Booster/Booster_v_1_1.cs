using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Booster_v_1_1 : MonoBehaviour
{
    public float Boostforce;
    public Vector3 Boostdirection;
    private Rigidbody Player_RB;
    public CinemachineFreeLook vcam;


    private void OnTriggerEnter(Collider other)
    {
        Player_RB = other.GetComponent<Rigidbody>();
        Player_RB.AddForce(Boostdirection * Boostforce, ForceMode.Impulse);
        //vcam.m_Lens.FieldOfView = 60;
    }
}
