using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CheckPoint : MonoBehaviour, ISaveable
{
    public float Checkpoint;
    public GameObject SavedIcon;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("test");
            PlayerManager.lastCheckPointPos = transform.position;
            StartCoroutine(IconWait());
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
