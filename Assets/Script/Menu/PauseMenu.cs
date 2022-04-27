using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public bool StoryIsplaying;

    public GameObject pauseMenuUI;
    AudioSource audioSrc;
    //BackgroundMusicManager Music;
    //SoundManager Sound;
    //Story story;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        //Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
        //Sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        //story = GameObject.Find("Player").GetComponent<Story>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                //BackgroundMusicManager.Instance.PlaySound("B_Music_1");
                Resume();
                //audioSrc.Play();
                //Debug.Log("playsound");
                //BackgroundMusicManager.Instance.PlaySound("B_Music_1");

            }
            else
            {
                Pause();
                //Music.StopMusic();
                //Sound.StopMusic();

            }
        }
    }
    public void Resume()
    {
        //story.UnPauseMusic();
        //BackgroundMusicManager.Instance.PlaySound("B_Music_1");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        //story.PauseMusic();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        StoryIsplaying = false;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        //TODO place Main Menu music
        //BackgroundMusicManager.Instance.PlaySound("MainMenu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
}
