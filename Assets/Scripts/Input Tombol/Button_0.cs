using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_0 : MonoBehaviour
{
    [SerializeField] Text inputField;

    public Sprite[] randomSprite;    

    public string InputString;

    public void ButtonPressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        InputString += buttonValue;

        inputField.text = InputString;

        gameObject.GetComponent<Image>().sprite = randomSprite[Random.Range(0, randomSprite.Length)];
    }
}
