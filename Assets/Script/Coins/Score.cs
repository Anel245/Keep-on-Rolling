using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI FinalScoreText;
    public static int theScore;
    public float Timer;
    private float PrTimer;
    private bool Counting;
    public int MaxScore;

    public GameObject AllCollected;
    public GameObject NotAllCollected;

    private void Awake()
    {
        theScore = 0;
    }

    void Update ()
    {
        ScoreText.text = "" + theScore;
        FinalScoreText.text = theScore + "/" + MaxScore;

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

        if (theScore == MaxScore)
        {
            AllCollected.SetActive(true);
            NotAllCollected.SetActive(false);
        }
        if (theScore > PlayerPrefs.GetInt("HighscoreLvl" + SceneManager.GetActiveScene().buildIndex, 0))
        {
            PlayerPrefs.SetInt("HighscoreLvl" + SceneManager.GetActiveScene().buildIndex, theScore);
        }
    }

    public void Collected()
    {
        ScoreText.fontSize = 50;
        Counting = true;
        PrTimer = 0;
    }
}
