using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI highScore;
    private float startTime;
    private bool finnished = false;
    

    void Start()
    {
        startTime = Time.time;
        // Display the HighScore
        highScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
    void Update()
    {
        if (finnished)
        {
            // If the time that the player took to finish the level is lower as was it is save in the highScore then...
            if (startTime < PlayerPrefs.GetFloat("HighScore", 0))
            {
              Debug.Log("better time");
              // The highscore is set here
              PlayerPrefs.SetFloat("HighScore", startTime);
              // Update the highscore
              highScore.text = startTime.ToString();
            }
            return;
        }

        else
        {

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        TimerText.text = minutes + ":" + seconds;
        }
    }

    public void Finnish()
    {
        finnished = true;
        TimerText.color = Color.red;
    }









    //[Header("Component")]
    //public TextMeshProUGUI TimerText;

    //[Header("Timer Settings")]
    //public float currentTime;
    //public bool countDown;

    //[Header("Limit Settings")]
    //public bool hasLimit;
    //public float timerLimit;


    //void Update()
    //{
    //    currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

    //    if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
    //    {
    //        currentTime = timerLimit;
    //        //SetTimerText();
    //        TimerText.color = Color.red;
    //        enabled = false;
    //    }
    //    SetTimerText();
    //}

    //private void SetTimerText()
    //{
    //    TimerText.text = currentTime.ToString("0.0");

    //}
}
