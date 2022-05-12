using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public TimerManager timerManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        timerManager.Finnish();
        //GameObject.Find("Player").SendMessage("Finnish");
    }
}