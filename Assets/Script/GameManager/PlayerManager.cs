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
    public AudioManager audioManager;


    void Update()
    {
        if (Player.transform.position.y < -Fallheight && !deathFeedbackFinished)
        {
            Debug.Log("falling");
            if (deathFeedback != null && !deathFeedbackActive)
            {
                deathFeedbackActive = true;
                Player.GetComponent<Ball_Movement_1_4>().Dead = true;
                audioManager.Falldown_Failure();
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
            Player.GetComponent<Ball_Movement_1_4>().Dead = false;
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
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Crusher")
        {
            Debug.Log("Ouch");
            audioManager.Enemy_Collision_Respawn();
            deathFeedbackActive = true;
            Player.GetComponent<Ball_Movement_1_4>().Dead = true;
            rb.velocity = Vector3.zero;
            deathFeedback.PlayFeedbacks();
        }
    }

    public void Dying()
    {
        //Save_2.DeleteSavedData();
    }

}
