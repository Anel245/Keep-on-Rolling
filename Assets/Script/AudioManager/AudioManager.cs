using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void Button_Click()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Button_Click");        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
