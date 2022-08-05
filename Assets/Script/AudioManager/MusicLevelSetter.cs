using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLevelSetter : MonoBehaviour
{
    public AudioManager audioManager;
    public int MusicLevel;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void SetMusicLvl()
    {
        audioManager.MusicSetLevel(MusicLevel);
    }
}
