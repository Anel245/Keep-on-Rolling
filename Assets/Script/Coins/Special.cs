using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject CollectedIcon;
    public GameObject NotCollectedIcon;
    public AudioManager audioManager;

    private void Awake()
    {
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        CollectedIcon.SetActive(true);
        NotCollectedIcon.SetActive(false);
        audioManager.Spec_Collectible();
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
