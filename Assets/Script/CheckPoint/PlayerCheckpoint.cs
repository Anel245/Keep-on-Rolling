using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject Checkpoint;
    public GameObject Checkpoint_1;
    public GameObject Player;
    Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
        Debug.Log(spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y < -2f)
        {
            Debug.Log("falling");
           // spawnPoint = Checkpoint.transform.position;
            //Player.transform.position = Checkpoint.transform.position;
            Player.transform.position = spawnPoint;
            Debug.Log(spawnPoint);
            Debug.Log(Player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!Player.CompareTag("CheckPoint"))
        {
            Debug.Log("Checkpoint");
            spawnPoint = Checkpoint.transform.position;
            //Player.transform.position = Checkpoint.transform.position;
            //Destroy(Checkpoint); CheckPoint_2
        }
        if (!Player.CompareTag("CheckPoint_2"))
        {
            Debug.Log("Checkpoint");
            spawnPoint = Checkpoint_1.transform.position;
            //Player.transform.position = Checkpoint.transform.position;
            //Destroy(Checkpoint); CheckPoint_2
        }
    }
}