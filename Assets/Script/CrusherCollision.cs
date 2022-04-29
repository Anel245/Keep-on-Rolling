using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Player is touching crusher");
            PlayerManager.lastCheckPointPos = transform.position;
        }

    }
}
