//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class RatingManager : MonoBehaviour
//{
//    public Score Scorescript;
//    public TimerManager Timerscript;


//    [Header("Time Values")]
//    public float GoodTime;
//    public float MiddleTime;
//    public float BadTime;

//    [Header("Score Values")]
//    public float GoodScore;
//    public float MiddleScore;
//    public float BadScore;

//    [Header("Stars")]
//    public GameObject HalfStarLeft_1;
//    public GameObject HalfStarRight_1;
//    public GameObject HalfStarLeft_2;
//    public GameObject HalfStarRight_2;
//    public GameObject HalfStarLeft_3;
//    public GameObject HalfStarRight_3;
//    public GameObject NoStars;

//    private void Awake()
//    {
//        Scorescript = GameObject.Find("Score").GetComponent<Score>();
//        Timerscript = GameObject.Find("Timemanager").GetComponent<TimerManager>();

//    }
//    void Start()
//    {   // Good Time and Good Score
//        if (TimerManager.startTime < GoodTime && Score.theScore > GoodScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 3 Stars
//            HalfStarRight_2.SetActive(true);
//            HalfStarLeft_3.SetActive(true);
//            HalfStarRight_3.SetActive(true);
//        }
//        // Good Time and Middle Score
//        if (Time < GoodTime && Score.theScore > MiddleScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 2 Stars and a Half
//            HalfStarRight_2.SetActive(true);
//            HalfStarLeft_3.SetActive(true);
//        }
//        // Good Time and Bad Score
//        if (Time < GoodTime && Score.theScore > BadScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 2 Stars
//            HalfStarRight_2.SetActive(true);
//        }
//        // Middle Time and Good Score
//        if (Time < MiddleTime && Score.theScore > GoodScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 2 Stars and a Half
//            HalfStarRight_2.SetActive(true);
//            HalfStarLeft_3.SetActive(true);
//        }
//        // Middle Time and Middle Score
//        if (Time < MiddleTime && Score.theScore > MiddleScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 1 Star and a Half
//        }
//        // Middle Time and Bad Score
//        if (Time < MiddleTime && Score.theScore > BadScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);               // 1 Star 
//        }
//        // Bad Time and Good Score
//        if (Time < BadTime && Score.theScore > GoodScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);
//            HalfStarLeft_2.SetActive(true);                // 2 Stars
//            HalfStarRight_2.SetActive(true);
//        }
//        // Bad Time and Middle Score
//        if (Time < BadTime && Score.theScore > MiddleScore)
//        {
//            HalfStarLeft_1.SetActive(true);
//            HalfStarRight_1.SetActive(true);               // 1 Star 
//        }
//        // Bad Time and Bad Score
//        if (Time < BadTime && Score.theScore > BadScore)
//        {
//            NoStars.SetActive(true);                     // No Stars
//        }
//    }

    
//}
