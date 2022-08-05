using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeGameUI;
    public Button SelectedEndscreenButton;
    public Ball_Movement_1_4 Player;
    public CinemachineFreeLook CinemachineCam;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    public void CompleteLevel()
    {
        Debug.Log("LevelWon");
        completeGameUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //Time.timeScale = 0;
        Player = FindObjectOfType<Ball_Movement_1_4>();
        Player.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        CinemachineCam = FindObjectOfType<CinemachineFreeLook>();
        CinemachineCam.gameObject.SetActive(false);
        SelectedEndscreenButton.Select();
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
