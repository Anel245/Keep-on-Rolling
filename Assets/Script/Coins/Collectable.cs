using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour, ISaveable
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Vector3 rotation = Vector3.up;

    public float coin;
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


    void OnTriggerEnter(Collider other)
    {
        Score.theScore += 1;
        Destroy(gameObject);
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
