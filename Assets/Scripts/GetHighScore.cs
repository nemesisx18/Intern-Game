using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetHighScore : MonoBehaviour
{
    public TextMeshProUGUI HighScore1;
    public TextMeshProUGUI HighScore2;
    public TextMeshProUGUI HighScore3;
    public TextMeshProUGUI HighScore4;
    // Start is called before the first frame update
    void Start()
    {
        HighScore1.text = PlayerPrefs.GetFloat("HighScore", 0) + "";
        HighScore2.text = PlayerPrefs.GetFloat("HighScore2", 0) + "";
        HighScore3.text = PlayerPrefs.GetFloat("HighScore3", 0) + "";
        HighScore4.text = PlayerPrefs.GetFloat("HighScore4", 0) + "";
    }

    public void ResetHighScoreAll()
    {
        PlayerPrefs.DeleteAll();
    }

}
