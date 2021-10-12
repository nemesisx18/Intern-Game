using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    public GameObject slide1;
    public GameObject slide2;
    public GameObject slide3;

    public Button prevbtn;
    public Button nextbtn;

    public int a = 1;

    public void Update()
    {
        if (a == 1)
        {
            slide1.SetActive(true);
            slide2.SetActive(false);
            slide3.SetActive(false);
            prevbtn.interactable = false;
        }
        if (a == 2)
        {
            slide1.SetActive(false);
            slide2.SetActive(true);
            slide3.SetActive(false);
            prevbtn.interactable = true;
            nextbtn.interactable = true;
        }
        if (a == 3)
        {
            slide1.SetActive(false);
            slide2.SetActive(false);
            slide3.SetActive(true);
            nextbtn.interactable = false;
        }
    }

    public void NextBTN()
    {
        if (a == 1)
        {
            a = 2;
            return;
        }
        if (a == 2)
        {
            a = 3;
            return;
        }
        
    }

    public void PrevBTN()
    {
        if (a == 3)
        {
            a = 2;
            return;
        }
        if (a == 2)
        {
            a = 1;
            return;
        }
    }
}
