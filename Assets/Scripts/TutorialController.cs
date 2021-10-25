using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    public GameObject slide1;
    public GameObject slide2;
    public GameObject slide3;
    public GameObject slide4;
    public GameObject slide5;
    public GameObject slide6;

    public Button prevbtn;
    public Button nextbtn;

    public int a = 1;

    public void Update()
    {
        if (a == 1)
        {
            slide1.SetActive(true);
            slide2.SetActive(false);
            //slide3.SetActive(false);
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
            //slide1.SetActive(false);
            slide2.SetActive(false);
            slide3.SetActive(true);
            slide4.SetActive(false);
            //nextbtn.interactable = false;
        }
        if (a == 4)
        {
            slide3.SetActive(false);
            slide4.SetActive(true);
            slide5.SetActive(false);
        }
        if (a == 5)
        {
            slide4.SetActive(false);
            slide5.SetActive(true);
            slide6.SetActive(false);
        }
        if (a == 6)
        {
            slide5.SetActive(false);
            slide6.SetActive(true);
            nextbtn.interactable = false;
        }
    }

    public void NextBTN()
    {
        if (a == 1)
        {
            a++;
            return;
        }
        if (a == 2)
        {
            a++;
            return;
        }
        if (a == 3)
        {
            a++;
            return;
        }
        if (a == 4)
        {
            a++;
            return;
        }
        if (a == 5)
        {
            a++;
            return;
        }
        
    }

    public void PrevBTN()
    {
        if (a == 6)
        {
            a--;
            return;
        }
        if (a == 5)
        {
            a--;
            return;
        }
        if (a == 4)
        {
            a--;
            return;
        }
        if (a == 3)
        {
            a--;
            return;
        }
        if (a == 2)
        {
            a--;
            return;
        }
    }
}
