using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] randomButton;

    public Button btn;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void RandomButton()
    {
        spriteRenderer.sprite = randomButton[Random.Range(0, randomButton.Length)];
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.btn.interactable = true;
            spriteRenderer.color = new Color(255, 0, 0);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.btn.interactable = false;
            spriteRenderer.color = new Color(255, 255, 255);
        }
    }
}
