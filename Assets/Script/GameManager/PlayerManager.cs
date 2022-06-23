using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector3 lastCheckPointPos;
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
        //if (Player.transform.position = lastCheckPointPos)
        //{
        //    LoadCoin()
        //}
    }

    private void Awake()
    {
        //GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        lastCheckPointPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Crusher")
        {
            Debug.Log("Ouch");
            Player.transform.position = lastCheckPointPos;
        }
    }

    public void Dying()
    {
        //Save_2.DeleteSavedData();
    }

}
