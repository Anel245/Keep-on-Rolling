using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public string ScenenName = "ScenenName";
    public void loadscene()
    {
        SceneManager.LoadScene(ScenenName);
    }
}
