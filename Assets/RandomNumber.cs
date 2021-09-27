using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumber : MonoBehaviour
{
    public TextMeshProUGUI txt_angka1;
    public TextMeshProUGUI txt_angka2;
    public TextMeshProUGUI txt_angka3;
    public TextMeshProUGUI txt_aritmatika;
    public TextMeshProUGUI txt_hasil;
    public TMP_InputField txt_input;

    double angka1, angka2, angka3 ,aritmatika;

    public double hasil, inputJawaban;
    

    private void Start()
    {
        angka1 = Random.Range(0, 10);
        angka2 = Random.Range(0, 10);
        aritmatika = Random.Range(0, 4);

        if (aritmatika == 0)
        {
            txt_aritmatika.text = " + ";
            hasil = angka1 + angka2;
        }
        else if (aritmatika == 1)
        {
            txt_aritmatika.text = " - ";
            hasil = angka1 - angka2;
        }
        else if (aritmatika == 2)
        {
            txt_aritmatika.text = " * ";
            hasil = angka1 * angka2;
        }
        else if (aritmatika == 3)
        {
            txt_aritmatika.text = " / ";
            double a, b;
            a = angka1;
            b = angka2;
            hasil = a / b;
        }

        txt_angka1.text = angka1.ToString();
        txt_angka2.text = angka2.ToString();
        txt_hasil.text = hasil.ToString("0.##");
    }

    private void Update()
    {
        txt_input.text = inputJawaban.ToString();
    }

    public void inputJawabanKunci(double jawaban)
    {
        inputJawaban = jawaban;
        Debug.Log(inputJawaban);
    }

    public void cekJawaban()
    {
        if (inputJawaban == hasil)
        {
            angka1 = Random.Range(0, 10);
            angka2 = Random.Range(0, 10);
            aritmatika = Random.Range(0, 4);

            if (aritmatika == 0)
            {
                txt_aritmatika.text = " + ";
                hasil = angka1 + angka2;
            }
            else if (aritmatika == 1)
            {
                txt_aritmatika.text = " - ";
                hasil = angka1 - angka2;
            }
            else if (aritmatika == 2)
            {
                txt_aritmatika.text = " * ";
                hasil = angka1 * angka2;
            }
            else if (aritmatika == 3)
            {
                txt_aritmatika.text = " / ";
                hasil = angka1 / angka2;
            }

            txt_angka1.text = angka1.ToString();
            txt_angka2.text = angka2.ToString();
            txt_hasil.text = hasil.ToString("0.##");
        }
    }

    public void RandomNumberAll()
    {
        angka1 = Random.Range(0, 10);
        angka2 = Random.Range(0, 10);
        aritmatika = Random.Range(0, 4);

        if (aritmatika == 0)
        {
            txt_aritmatika.text = " + ";
            hasil = angka1 + angka2;
        }
        else if (aritmatika == 1)
        {
            txt_aritmatika.text = " - ";
            hasil = angka1 - angka2;
        }
        else if (aritmatika == 2)
        {
            txt_aritmatika.text = " * ";
            hasil = angka1 * angka2;
        }
        else if (aritmatika == 3)
        {
            txt_aritmatika.text = " / ";
            hasil = angka1 / angka2;
            
        }
        
        //float a = Mathf.Round(hasil);
        txt_angka1.text = angka1.ToString();
        txt_angka2.text = angka2.ToString();
        txt_hasil.text = hasil.ToString("0.##");
    } 
}
