using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] randomButton;

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
            Debug.Log("Player menyentuh");
            RandomButton();
        }
    }
}
