using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoreManager : MonoBehaviour
{
    public TextMeshProUGUI[] HighscoreTexts;
    public TextMeshProUGUI[] BestTimes;
    public int[] MaxScores;
    private int Index = 0;

    private void Awake()
    {
        foreach (var highscoretext in HighscoreTexts)
        {
            highscoretext.text = PlayerPrefs.GetInt("HighscoreLvl" + (Index + 1), 0) + "/" + MaxScores[Index];
            Index++;
        }

        Index = 0;

        foreach (var besttime in BestTimes)
        {
            if (PlayerPrefs.GetFloat("BestTimeLvl" + (Index + 1), 0) != 0)
            {
                string minutes = ((int)PlayerPrefs.GetFloat("BestTimeLvl" + (Index + 1), 0) / 60).ToString();
                string seconds = (PlayerPrefs.GetFloat("BestTimeLvl" + (Index + 1), 0) % 60).ToString("f1");

                besttime.text = minutes + ":" + seconds;
                Index++;
            }
        }
    }
}
