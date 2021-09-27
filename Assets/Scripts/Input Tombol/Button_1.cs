using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_1 : MonoBehaviour
{
    public RandomNumber randomNumber;

    public Text button;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            randomNumber.inputJawaban = randomNumber.inputJawaban + 1;

            Debug.Log("Log input" + button.text);
        }
    }
}
