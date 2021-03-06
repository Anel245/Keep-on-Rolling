using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoreMountains.Feedbacks;

public class Collectable : MonoBehaviour, ISaveable
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Vector3 rotation = Vector3.up;

    public float coin;
    public Score Scorescript;

    [Header("Feedbacks")]
    public MMF_Player collectedFeedback;
    public AudioManager audioManager;

    public object SaveState()
    {
        return new SaveData()
        {
            coin = this.coin
        };
    }
    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        coin = saveData.coin; ;
    }
    [Serializable]
    private struct SaveData
    {
        public float coin;
    }

    private void Awake()
    {
        Scorescript = GameObject.Find("Score").GetComponent<Score>();
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Score.theScore += 1;
        Scorescript.Collected();
        collectedFeedback.PlayFeedbacks();
        audioManager.Collectible();
        //Destroy(gameObject);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Score.instance.AddScore();
    //    Destroy(gameObject);
    //}

    private void Update()
    {
        transform.Rotate(rotation, rotationSpeed * Time.deltaTime);
    }
}
