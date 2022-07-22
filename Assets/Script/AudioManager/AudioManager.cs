using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance = null;
    
    private FMOD.Studio.EventInstance BallRollingInstance;
    private FMOD.Studio.EventInstance AmbientSkyInstance;
    private FMOD.Studio.EventInstance EnemyMoveInstance;
    public List<FMOD.Studio.EventInstance> EnemyMoveInstances;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        AmbientSkyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/2D/AmbientSky");
    }

    private void Start()
    {
        AmbientSkyStart();
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

    public void EnemyMoveInitialize(Transform EnemyTransform, Rigidbody EnemyRigidbody)
    {
        EnemyMoveInstance = FMODUnity.RuntimeManager.CreateInstance("event:/3D/Enemy_Movement");
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(EnemyMoveInstance, EnemyTransform, EnemyRigidbody);
        EnemyMoveInstance.start();
        //EnemyMoveInstances.Add(EnemyMoveInstance);
    }
    public void EnemyMovesStart()
    {
        foreach (var Instance in EnemyMoveInstances)
        {
            Instance.start();
        }
    }

    public void EnemyMovesStop()
    {
        foreach (var Instance in EnemyMoveInstances)
        {
            Instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
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
    }

    public void BallRollingStop()
    {
        BallRollingInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void BallImpact(Vector3 BallPosition)
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/3D/Ball_Impact", BallPosition);
    }

    public void AmbientSkyStart()
    {
        AmbientSkyInstance.start();
    }
    public void AmbientSkyStop()
    {
        AmbientSkyInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
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


    void Update()
    {
        
    }
}
