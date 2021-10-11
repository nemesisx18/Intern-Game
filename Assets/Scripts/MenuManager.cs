using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject UI_Tutorial;
    public GameObject settingUI;

    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void Setting()
    {
        //do something
        settingUI.SetActive(true);
        Debug.Log("open setting");
    }

    public void CloseSetting()
    {
        settingUI.SetActive(false);
    }

    public void ExitApp()
    {
        Application.Quit();
    }

    public void TutorialOpen()
    {
       UI_Tutorial.SetActive(true);
            
    }

    public void TutorialClose()
    {
        UI_Tutorial.SetActive(false);
    }

}
