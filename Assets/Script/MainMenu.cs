using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("Level01");
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void GoToMainMenu()
    {
       
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToControlsMenu()
    {
        SceneManager.LoadScene("ControlsMenu");
    }
    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void GoToWin()
    {
        SceneManager.LoadScene("Win");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
