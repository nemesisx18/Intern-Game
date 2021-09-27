using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_0 : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    
    public RandomNumber randomNumber;
    public PlayerController player;

    string InputString;

    public void ButtonPressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        InputString += buttonValue;

        inputField.text = InputString;
    }
}
