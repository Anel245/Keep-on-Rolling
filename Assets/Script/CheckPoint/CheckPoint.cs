using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using MoreMountains.Feedbacks;

public class CheckPoint : MonoBehaviour, ISaveable
{
    public float Checkpoint;
    public GameObject SavedIcon;

    public MMF_Player checkpointReachedFeedback;
    public AudioManager audioManager;

    private void Awake()
    {
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("CheckpointActivated");
            PlayerManager.lastCheckPointPos = transform.position;
            StartCoroutine(IconWait());
            if (checkpointReachedFeedback != null)
            {
                audioManager.Checkpoint();
                checkpointReachedFeedback.PlayFeedbacks();
            }
        }
    }

    public object SaveState()
    {
        return new SaveData()
        {
            Checkpoint = this.Checkpoint
        };
    }
    public void LoadState(object state)
    {
        var saveData = (SaveData)state;
        Checkpoint = saveData.Checkpoint;
    }
    [Serializable]
    private struct SaveData
    {
        public float Checkpoint;
    }

    IEnumerator IconWait()
    {
        SavedIcon.SetActive(true);
        yield return new WaitForSeconds(3);
        SavedIcon.SetActive(false);
    }
}
