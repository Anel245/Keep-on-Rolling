using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject CoinsText;
    public static int theScore;

    void Update ()
    {     
        CoinsText.GetComponent<Text>().text = "COINS:" + theScore;       
    }


    //int score = 0;
    //public TextMesh tm;
    //public static Score instance;

<<<<<<< Updated upstream
    //void Start()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //}

    //public void AddScore()
    //{
    //    score++;
    //    tm.text = score.ToString();
    //}
=======
    public void Collected()
    {
        theScore++;
        ScoreText.fontSize = 50;
        Counting = true;
        PrTimer = 0;
    }
>>>>>>> Stashed changes
}
