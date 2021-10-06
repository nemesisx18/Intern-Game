using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorChange1 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void OnMouseOver()
    {
        spriteRenderer.color = new Color(1, 1, 0, 1);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(1, 1, 1, 0);
    }

    public void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
