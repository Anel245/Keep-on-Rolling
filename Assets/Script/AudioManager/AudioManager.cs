using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;

    public GameObject BallObject;
    
    private FMOD.Studio.EventInstance BallRollingInstance;



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

    public void BallRollingInitialize()
    {
        BallRollingInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Ball_Rolling");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(BallRollingInstance, BallObject.GetComponent<Transform>(), BallObject.GetComponent<Rigidbody>());
        BallRollingInstance.setParameterByName("Speed", 0f);
    }

    public void BallRollingStart()
    {
        BallRollingInstance.start();
    }

    public void BallRollingSpeedUpdate(float BallSpeed)
    {
        BallRollingInstance.setParameterByName("Speed", BallSpeed);
    }

    public void BallRollingStop()
    {
        BallRollingInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }


    void Update()
    {
        
    }
}
