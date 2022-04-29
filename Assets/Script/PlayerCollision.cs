using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static Vector3 lastCheckPointPos = new Vector3(-36, 1, -40);
    public GameObject Player;

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Crusher")
        {
            Debug.Log("testCollision");
            Player.transform.position = lastCheckPointPos;
        }

    }
}
