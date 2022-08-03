using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAttach : MonoBehaviour
{
    private AudioManager audiomanager;
    public bool IsCar = false;
    public bool IsVent = false;
    public bool IsHolo = false;
    public bool IsCable = false;

    private void Awake()
    {
        audiomanager = FindObjectOfType<AudioManager>();
        if (IsCar)
            audiomanager.FlyingCarInitialize(gameObject);
        if(IsVent)
            audiomanager.VentilationInitialize(gameObject);
        if(IsHolo)
            audiomanager.HologramInitialize(gameObject);
        if(IsCable)
            audiomanager.SparkingCableInitialize(gameObject);
    }
}
