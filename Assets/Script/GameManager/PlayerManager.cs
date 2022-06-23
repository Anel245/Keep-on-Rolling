using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector3 lastCheckPointPos = new Vector3(-36, 1, -40);
    public GameObject Player;

    void Update()
    {
        if (Player.transform.position.y < -2f)
        {
            Debug.Log("falling");
            Player.transform.position = lastCheckPointPos;
            Debug.Log(lastCheckPointPos);
            Debug.Log(Player.transform.position);
        }
    }

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Crusher")
        {
            Debug.Log("Ouch");
            Player.transform.position = lastCheckPointPos;
        }
    }


}
