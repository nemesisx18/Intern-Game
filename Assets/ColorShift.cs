using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject tombol;

    public void OnMouseOver()
    {
        spriteRenderer.color = new Color(1, 1, 0, 1);
    }
}
