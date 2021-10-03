using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_0 : MonoBehaviour
{
    [SerializeField] Text inputField;

    public GameTimer gmTimer;

    public Sprite[] randomSprite;    

    public string InputString;

    public void Start()
    {
        GameObject a = GameObject.Find("_GameManager");
        gmTimer = a.GetComponent<GameTimer>();
    }

    public void ButtonPressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        gmTimer.jawabanInput += buttonValue;

        inputField.text = gmTimer.jawabanInput;

        gameObject.GetComponent<Image>().sprite = randomSprite[Random.Range(0, randomSprite.Length)];
    }

    public void resetTextJawaban()
    {
        inputField.text = null;
    }
}
