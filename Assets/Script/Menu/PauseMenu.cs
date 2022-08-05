using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour, Ball_Controlls.IBall_ControlsActions
{

    public bool GameIsPaused = false;
    public GameObject WinScreen;
    public GameObject PlayerUI;

    public GameObject pauseMenuUI;
    private Ball_Controlls controlls;
    public AudioManager audioManager;
    public Button FirstSelectedButton;

    public string Inputdevice;
    //BackgroundMusicManager Music;
    //SoundManager Sound;
    //Story story;

    void Awake()
    {
        //Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
        //Sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        //story = GameObject.Find("Player").GetComponent<Story>();
        if (GameObject.Find("AudioManager") != null)
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
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
            Inputdevice = context.control.device.name;
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
        //BackgroundMusicManager.Instance.PlaySound("B_Music_1");
        pauseMenuUI.SetActive(false);
        PlayerUI.SetActive(true);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
        //audioManager.BallRollingStart(transform, new Rigidbody());
        audioManager.UnPauseMenu();
        //audioManager.EnemyMovesStart();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        PlayerUI.SetActive(false);
        if (Inputdevice == "Keyboard")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            FirstSelectedButton.Select();
        }
        Time.timeScale = 0f;
        GameIsPaused = true;
        //audioManager.BallRollingStop();
        audioManager.PauseMenu();
        //audioManager.EnemyMovesStop();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        audioManager.StopAllEnvEmitters();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        //TODO place Main Menu music
        //BackgroundMusicManager.Instance.PlaySound("MainMenu");
        Time.timeScale = 1f;
        audioManager.StopAllEnvEmitters();
        SceneManager.LoadSceneAsync(0);
        audioManager.MusicStop();
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
