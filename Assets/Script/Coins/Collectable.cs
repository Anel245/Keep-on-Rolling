using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private Vector3 rotation = Vector3.up;

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
