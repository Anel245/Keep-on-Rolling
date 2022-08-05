using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSetter : MonoBehaviour
{
    public Slider SFXVolSlider;
    public Slider MusicVolSlider;

    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
        SFXVolSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1);
        MusicVolSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1);
    }

    public void SetMusicVol()
    {
        PlayerPrefs.SetFloat("MusicVolume", MusicVolSlider.value);
        audioManager.MusicBusSetVolume(MusicVolSlider.value);
    }

    public void SetSFXVol()
    {
        PlayerPrefs.SetFloat("SFXVolume", SFXVolSlider.value);
        audioManager.SFXBusSetVolume(SFXVolSlider.value);
    }
}
