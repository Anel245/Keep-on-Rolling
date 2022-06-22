using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public static int theScore;
    public float Timer;
    private float PrTimer;
    private bool Counting;

    void Update ()
    {
        ScoreText.text = "Score: " + theScore;

        if (Counting)
        {
            PrTimer += Time.deltaTime;
        }

        if (PrTimer > Timer)
        {
            Counting = false;
            PrTimer = 0;
            ScoreText.fontSize = 0;
        }
    }

    public void Collected()
    {
        ScoreText.fontSize = 50;
        Counting = true;
        PrTimer = 0;
    }
}
