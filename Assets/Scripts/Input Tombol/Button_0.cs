using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_0 : MonoBehaviour
{
    [SerializeField] Text inputField;

    public Button btn;
    
    public RandomNumber randomNumber;
    public PlayerController player;

    public string InputString;
    //public string tambahtext;

    private void Start()
    {
        //this.btn.interactable = false;
    }

    public void ButtonPressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        InputString += buttonValue;

        inputField.text = InputString;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.btn.interactable = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.btn.interactable = false;
        }
    }
}
