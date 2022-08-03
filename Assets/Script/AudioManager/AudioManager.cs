using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;
    
    private FMOD.Studio.EventInstance BallRollingInstance;
    private FMOD.Studio.EventInstance AmbientSkyInstance;
    private FMOD.Studio.EventInstance MusicInstance;
    private FMOD.Studio.Bus EnvEmittersBus;


    // private FMOD.Studio.EventInstance EnemyMoveInstance;
    // public List<FMOD.Studio.EventInstance> EnemyMoveInstances;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        AmbientSkyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/2D/AmbientSky");
        EnvEmittersBus = FMODUnity.RuntimeManager.GetBus("bus:/SFX/EnvEmitters");
        MusicInstance = FMODUnity.RuntimeManager.CreateInstance("event:/2D/Music");

        //AmbientSkyStart();
    }

    public void Button_Click()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Button_Click");        
    }

    public void Button_Hover()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Button_Hover");
    }

    public void Button_Cancel()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Button_Cancel");
    }

    
    // Environment Emitters ------------------------------------------------------------------

    public void EnemyMoveInitialize(Transform EnemyTransform, Rigidbody EnemyRigidbody)
    {
        FMOD.Studio.EventInstance EnemyMoveInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Enemy_Movement");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(EnemyMoveInstance, EnemyTransform, EnemyRigidbody);
        EnemyMoveInstance.start();
        EnemyMoveInstance.release();
        //EnemyMoveInstances.Add(EnemyMoveInstance);
    }


    public void FlyingCarInitialize(GameObject FlyingCar)
    {
        FMOD.Studio.EventInstance FlyingCarInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Flying_Car");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(FlyingCarInstance, FlyingCar.transform, FlyingCar.GetComponent<Rigidbody>());
        FlyingCarInstance.start();
        FlyingCarInstance.release();
    }

    public void HologramInitialize(GameObject Hologram)
    {
        FMOD.Studio.EventInstance HologramInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Hologram");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(HologramInstance, Hologram.transform, Hologram.GetComponent<Rigidbody>());
        HologramInstance.start();
        HologramInstance.release();
    }

    public void VentilationInitialize(GameObject Ventilation)
    {
        FMOD.Studio.EventInstance VentilationInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Ventilation");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(VentilationInstance, Ventilation.transform, Ventilation.GetComponent<Rigidbody>());
        VentilationInstance.start();
        VentilationInstance.release();
    }

    public void SparkingCableInitialize(GameObject SparkingCable)
    {
        FMOD.Studio.EventInstance SparkingCableInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Sparking_Cable");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(SparkingCableInstance, SparkingCable.transform, SparkingCable.GetComponent<Rigidbody>());
        SparkingCableInstance.start();
        SparkingCableInstance.release();
    }

    public void StopAllEnvEmitters()
    {
        //Stops all instances of EnemyMove, FlyingCar, Hologram, Ventilation, SparkingCable, BallRolling
        EnvEmittersBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void PauseMenu()
    {
        EnvEmittersBus.setPaused(true);
    }
    public void UnPauseMenu()
    {
        EnvEmittersBus.setPaused(false);
    }

    public void BallRollingInitialize(Transform Balltransform, Rigidbody BallRigidbody)
    {
        BallRollingInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Ball_Rolling");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(BallRollingInstance, Balltransform, BallRigidbody);
        BallRollingInstance.setParameterByName("Speed", 0f);
    }

    public void BallRollingStart(Transform Balltransform, Rigidbody BallRigidbody)
    {
        BallRollingInstance.start();
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(BallRollingInstance, Balltransform, BallRigidbody);
    }

    public void BallRollingSpeedUpdate(float BallSpeed)
    {
        BallRollingInstance.setParameterByName("Speed", BallSpeed);
        MusicInstance.setParameterByName("Speed", BallSpeed);
    }

    // End of Environment Emitters ------------------------------------------------------------------


    public void BallRollingStop()
    {
        BallRollingInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void BallImpact(Vector3 BallPosition)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/3D/Ball_Impact", BallPosition);
    }

    public void Bounce(Vector3 BallPosition)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/3D/Bounce", BallPosition);
    }

    public void Jump(Vector3 BallPosition)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/3D/Jump", BallPosition);
    }

    public void Collectible()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Collectible");
    }

    public void Spec_Collectible()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Spec_Collectible");
    }

    public void Boost()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Boost");
    }

    public void Checkpoint()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Checkpoint");
    }

    public void Enemy_Collision_Respawn()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Enemy_Collision_Respawn");
    }

    public void Falldown_Failure()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Falldown_Failure");
    }

    public void FinishLevel()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/2D/Finish_Level");
    }

    public void AmbientSkyStart()
    {
        AmbientSkyInstance.start();
    }
    public void AmbientSkyStop()
    {
        AmbientSkyInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void MusicStart()
    {
        MusicInstance.start();
    }
    public void MusicStop()
    {
        MusicInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }


    void Update()
    {
        
    }
}
