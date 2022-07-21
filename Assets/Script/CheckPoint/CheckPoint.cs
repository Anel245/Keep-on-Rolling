using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

<<<<<<< Updated upstream
public class CheckPoint : MonoBehaviour/* ISaveable*/
=======
public class CheckPoint : MonoBehaviour
>>>>>>> Stashed changes
{
    public float Checkpoint;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.tag == "Player") 
        {
            Debug.Log("test");
            PlayerManager.lastCheckPointPos = transform.position;
        }
        
    }
<<<<<<< Updated upstream
=======
    IEnumerator IconWait()
    {
        SavedIcon.SetActive(true);
        yield return new WaitForSeconds(3);
        SavedIcon.SetActive(false);
    }

>>>>>>> Stashed changes
    //public object SaveState()
    //{
    //    return new SaveData()
    //    {
    //        Checkpoint = this.Checkpoint
    //    };
    //}
    //public void LoadState(object state)
    //{
    //    var saveData = (SaveData)state;
    //    Checkpoint = saveData.Checkpoint;
    //}
    //[Serializable]
    //private struct SaveData
    //{
    //    public float Checkpoint;
    //}

}
