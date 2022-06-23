using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector3 lastCheckPointPos;
    public GameObject Player;
    public float Fallheight;
    private Rigidbody rb;

    void Update()
    {
        if (Player.transform.position.y < -Fallheight)
        {
            Debug.Log("falling");
            Player.transform.position = lastCheckPointPos;
            rb.velocity = Vector3.zero;
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
        rb = Player.GetComponent<Rigidbody>();
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
