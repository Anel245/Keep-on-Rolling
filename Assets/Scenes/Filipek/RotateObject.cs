using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    float speed = 75f;

    private void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}