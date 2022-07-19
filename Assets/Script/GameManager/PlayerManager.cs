using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class PlayerManager : MonoBehaviour
{
    public static Vector3 lastCheckPointPos;
    public GameObject Player;
    public float Fallheight;
    private Rigidbody rb;
    public bool deathFeedbackFinished;
    public MMF_Player deathFeedback;
    public bool deathFeedbackActive;

    void Update()
    {
        if (Player.transform.position.y < -Fallheight && !deathFeedbackFinished)
        {
            Debug.Log("falling");
            if (deathFeedback != null && !deathFeedbackActive)
            {
                deathFeedbackActive = true;
                deathFeedback.PlayFeedbacks();
            }
            //Player.transform.position = lastCheckPointPos;
            //rb.velocity = Vector3.zero;
            //Debug.Log(lastCheckPointPos);
            //Debug.Log(Player.transform.position);
        }
        if (deathFeedbackFinished)
        {
            Player.transform.position = lastCheckPointPos;
            rb.velocity = Vector3.zero;
            Debug.Log(lastCheckPointPos);
            Debug.Log(Player.transform.position);
            deathFeedbackFinished = false;
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
            rb.velocity = Vector3.zero;
        }
    }

    public void Dying()
    {
        //Save_2.DeleteSavedData();
    }

}
