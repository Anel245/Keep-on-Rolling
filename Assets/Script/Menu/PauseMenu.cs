using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{

    public bool GameIsPaused = false;
    public GameObject WinScreen;
    public GameObject PlayerUI;

    public GameObject pauseMenuUI;
    public AudioSource audioSrc;
    private Ball_Controlls controlls;
    //BackgroundMusicManager Music;
    //SoundManager Sound;
    //Story story;

    void Awake()
    {
        //Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
        //Sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        //story = GameObject.Find("Player").GetComponent<Story>();

        //Get controller
        if (controlls == null)
        {
            controlls = new Ball_Controlls();
            controlls.Enable();
            controlls.Ball_Controls.SetCallbacks(this);
        }
    }

    public void OnPauseMenu(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (WinScreen.activeSelf == false)
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
    }

    public void Resume()
    {
        audioSrc.UnPause();
        //BackgroundMusicManager.Instance.PlaySound("B_Music_1");
        pauseMenuUI.SetActive(false);
        PlayerUI.SetActive(true);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
    }

    void Pause()
    {
        audioSrc.Pause();
        pauseMenuUI.SetActive(true);
        PlayerUI.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
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
        SceneManager.LoadScene(0);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
    }

    public void OnJump(InputAction.CallbackContext context)
    {
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {
    }
}
