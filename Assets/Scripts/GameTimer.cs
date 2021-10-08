using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 10;
    public float score;
    public int levelSelect;
    public int nextSceneLoad;

    public string jawabanInput;

    public bool timerIsRunning = false;

    public Slider countBar;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighscoreText;

    public GameObject UI_PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        timerIsRunning = true;
        scoreText.text = score.ToString();
        //HighscoreText.text = PlayerPrefs.GetFloat("Highscore").ToString();
        
        //set bar max value
        countBar.maxValue = timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        countBar.value += Time.deltaTime;

        RunTimer();
        scoreText.text = score.ToString();
        HighscoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            UI_PauseMenu.SetActive(true);
        }
    }

    public void AddScore()
    {
        score += 5;
    }

    public void RunTimer()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");

                Time.timeScale = 0;
                SetHighScore();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void SetHighScore()
    {

        if (levelSelect == 1)
        {
            if (score > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", score);
            }

            if (score >= 50)
            {
                NextLevel();
            }
            
        }
        else if (levelSelect == 2)
        {
            if (score > PlayerPrefs.GetFloat("HighScore2", 0))
            {
                PlayerPrefs.SetFloat("HighScore2", score);
            }

            if (score >= 40)
            {
                NextLevel();
            }
        }
        else if (levelSelect == 3)
        {
            if (score > PlayerPrefs.GetFloat("HighScore3", 0))
            {
                PlayerPrefs.SetFloat("HighScore3", score);
            }

            if (score >= 30)
            {
                NextLevel();
            }
        }
        else if (levelSelect == 4)
        {
            if (score > PlayerPrefs.GetFloat("HighScore4", 0))
            {
                PlayerPrefs.SetFloat("HighScore4", score);
            }

            if (score >= 50)
            {
                NextLevel();
            }
        }

    }

    private void NextLevel()
    {
        if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        }
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        UI_PauseMenu.SetActive(false);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: levelSelect + 1);
    }
}
