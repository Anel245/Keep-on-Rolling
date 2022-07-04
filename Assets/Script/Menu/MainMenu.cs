using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider XSensitivitySlider;
    public Slider YSensitivitySlider;

    private void Awake()
    {
        XSensitivitySlider.value = PlayerPrefs.GetFloat("XMouseSensitivity", 0.7f);
        YSensitivitySlider.value = PlayerPrefs.GetFloat("YMouseSensitivity", 0.7f);
    }

    private void Update()
    {
        if (XSensitivitySlider.value != PlayerPrefs.GetFloat("XMouseSensitivity") || YSensitivitySlider.value != PlayerPrefs.GetFloat("YMouseSensitivity"))
        {
            PlayerPrefs.SetFloat("XMouseSensitivity", XSensitivitySlider.value);
            PlayerPrefs.SetFloat("YMouseSensitivity", YSensitivitySlider.value);
            Debug.Log("MouseX " + PlayerPrefs.GetFloat("XMouseSensitivity") + " MouseY " + PlayerPrefs.GetFloat("YMouseSensitivity"));
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }

}
