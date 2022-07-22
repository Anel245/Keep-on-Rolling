using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject CollectedIcon;
    public GameObject NotCollectedIcon;

    private void OnTriggerEnter(Collider other)
    {
        CollectedIcon.SetActive(true);
        NotCollectedIcon.SetActive(false);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
