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

    void Button_Click()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Button_Click");        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
