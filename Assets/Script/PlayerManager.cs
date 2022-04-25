using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector3 lastCheckPointPos = new Vector3(-36, 1, -40);
   

    private void Awake()
    {
        GameObject.FindGameObjectsWithTag("Player").transform.position = lastCheckPointPos;
    }
}
