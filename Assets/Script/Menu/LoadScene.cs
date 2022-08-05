using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private AudioManager audioManager;
    public int ScenenBuildIndex;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    public void loadscene()
    {
        if (ScenenBuildIndex == 0)
            audioManager.MusicSetLevel(0);
        SceneManager.LoadSceneAsync(ScenenBuildIndex);
    }
}
