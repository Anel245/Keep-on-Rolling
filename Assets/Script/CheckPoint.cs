using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CheckPoint : MonoBehaviour, ISaveable
{
    public float Checkpoint;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Player") 
        {
            PlayerManager.lastCheckPointPos = transform.position;
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

}
