using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void Setting()
    {
        //do something
        Debug.Log("open setting");
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
