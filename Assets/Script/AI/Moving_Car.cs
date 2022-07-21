using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Car : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = transform;
    }

    private void OnCollisionExit(Collision collision)
    {
        Player.transform.parent = null;
    }

}
