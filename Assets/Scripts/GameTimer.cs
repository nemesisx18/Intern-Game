using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 10;
    public float score;

    public string jawabanInput;

    public bool timerIsRunning = false;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighscoreText;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        scoreText.text = score.ToString();
        //HighscoreText.text = PlayerPrefs.GetFloat("Highscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        RunTimer();
        scoreText.text = score.ToString();
        HighscoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();
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
        if (score > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
    }

}
