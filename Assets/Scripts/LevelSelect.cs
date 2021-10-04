using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button[] lvlSelect;
    // Start is called before the first frame update
    void Start()
    {
        int LevelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < lvlSelect.Length; i++)
        {
            if (i + 2 > LevelAt)
            {
                lvlSelect[i].interactable = false;
            }
        }
    }

    public void Level1()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("LEVEL2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("LEVEL3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("LEVEL4");
    }
}
