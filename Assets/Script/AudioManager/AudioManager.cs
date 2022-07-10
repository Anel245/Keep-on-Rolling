using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;

    public GameObject BallObject;
    
    private FMOD.Studio.EventInstance BallRollingInstance;
    private FMOD.Studio.EventInstance AmbientSkyInstance;



    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void Button_Click()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Button_Click");        
    }

    public void Button_Hover()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Button_Hover");
    }

    public void Button_Cancel()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Button_Cancel");
    }

    void Start()
    {
        AmbientSkyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/AmbientSky");
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

    public void BallImpact(Vector3 BallPosition)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Ball_Impact", BallPosition);
    }

    public void AmbientSkyStart()
    {
        AmbientSkyInstance.start();
    }
    public void AmbientSkyStop()
    {
        AmbientSkyInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    void Update()
    {
        
    }
}
