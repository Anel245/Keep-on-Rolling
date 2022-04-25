using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
  


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Player") 
        {
            PlayerManager.lastCheckPointPos = transform.position;
        }
        
    }

}
