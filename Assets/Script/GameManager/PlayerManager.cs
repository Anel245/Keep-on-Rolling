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
            Player.transform.position = lastCheckPointPos;
<<<<<<< Updated upstream
            Debug.Log(lastCheckPointPos);
            Debug.Log(Player.transform.position);
=======
            rb.velocity = Vector3.zero;
>>>>>>> Stashed changes
        }
    }

    private void Awake()
    {
<<<<<<< Updated upstream
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
=======
        lastCheckPointPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        rb = Player.GetComponent<Rigidbody>();
>>>>>>> Stashed changes
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Crusher")
        {
            Debug.Log("Ouch");
            Player.transform.position = lastCheckPointPos;
        }
    }

<<<<<<< Updated upstream
=======
    //public void Dying()
    //{
    //    //Save_2.DeleteSavedData();
    //}
>>>>>>> Stashed changes

}
