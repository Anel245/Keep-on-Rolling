using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private Animator anim;
    private string hit_ANIMATION = "Hit";
    public void GoToLevel02()
    {
        SceneManager.LoadScene("Level02");
    }
    public void GoToLevel03()
    {
        SceneManager.LoadScene("Level03");
    }
    public void GoToLevel04()
    {
        SceneManager.LoadScene("Level04");
    }
    public void GoToLevel05()
    {
        SceneManager.LoadScene("Level05");
    }
    public void GoToLevel06()
    {
        SceneManager.LoadScene("Level06");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "ToLevel02")
        {
            //GetComponent<MainMenu>().GoToWin();
            GoToLevel02();
        }
        if (collision.transform.tag == "ToLevel03")
        {
            //GetComponent<MainMenu>().GoToWin();
            GoToLevel03();
        }
        if (collision.transform.tag == "ToLevel04")
        {
            //GetComponent<MainMenu>().GoToWin();
            GoToLevel04();
        }
        if (collision.transform.tag == "ToLevel05")
        {
            //GetComponent<MainMenu>().GoToWin();
            GoToLevel05();
        }
        if (collision.transform.tag == "ToLevel06")
        {
            //GetComponent<MainMenu>().GoToWin();
            GoToLevel06();
        }
    }


}