using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public TimerManager timerManager;
    private AudioManager audioManager;

    private void Awake()
    {
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
    }

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        timerManager.Finnish();
        audioManager.BallRollingStop();
        audioManager.FinishLevel();

        //TimerText.text.SetActive(true);
        //GameObject.Find("Player").SendMessage("Finnish");
    }
}