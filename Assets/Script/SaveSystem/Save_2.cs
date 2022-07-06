using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_2 : MonoBehaviour
{
    public GameObject Coin;

    public void Start()
    {
        name = Coin.name;
    }
    public void SaveCoin()
    {
        
        //PlayerPrefs.SetString(id,name);
        Debug.Log("You collected " + PlayerPrefs.GetString("name"));
    }
    public void DeleteLastSavedData()
    {
        //when the player dies before touching the next checkpoint delete the data that were saved
        PlayerPrefs.DeleteKey("name");
    }
    public void LoadCoin()
    {
        PlayerPrefs.GetString("name");
    }
 
}
