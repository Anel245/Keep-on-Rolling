using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public TimerManager timerManager;
    public TextMeshProUGUI TimerText;
    

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        timerManager.Finnish();
        TimerText.gameObject.SetActive(true);
        //TimerText.text.SetActive(true);
        //GameObject.Find("Player").SendMessage("Finnish");


    }
}