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

    public Button_0 button;
    public GameTimer gmTimer;

    double angka1, angka2, angka3 ,aritmatika;

    public double hasil, inputJawaban;

    public double[] soal_angka1;
    public double[] soal_angka2;


    private void Start()
    {
        RandomNumberAll();
    }

    private void Update()
    {
        inputJawaban = System.Convert.ToDouble(gmTimer.jawabanInput);
        txt_input.text = inputJawaban.ToString();
        if (inputJawaban != null)
        {
            AutoCekjawaban();
        }
        
    }

    public void AutoCekjawaban()
    {
        if (inputJawaban == hasil)
        {
            RandomNumberAll();

            gmTimer.jawabanInput = null;
            gmTimer.timeRemaining += 5f;
            gmTimer.AddScore();
        }
    }

    public void resetJawaban()
    {
        gmTimer.jawabanInput = null;
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
            RandomNumberAll();

            gmTimer.jawabanInput = null;
        }
        if (inputJawaban != hasil)
        {
            gmTimer.jawabanInput = null;
        }
    }

    public void RandomNumberAll()
    {
        if (gmTimer.levelSelect == 1)
        {
            aritmatika = 0;
            AritmatikaMethod();
        }
        else if (gmTimer.levelSelect == 2)
        {
            aritmatika = Random.Range(0, 2);
            AritmatikaMethod();
        }
        else if (gmTimer.levelSelect == 3)
        {
            aritmatika = Random.Range(0, 3);
            AritmatikaMethod();
        }
        else if (gmTimer.levelSelect == 4)
        {
            aritmatika = Random.Range(0, 4);
            AritmatikaMethod();
        }
        
    }

    private void AritmatikaMethod()
    {
        //ARITMATIKA PENJUMLAHAN (+)
        if (aritmatika == 0)
        {
            angka1 = Random.Range(0, 51);
            angka2 = Random.Range(0, 51);
            txt_aritmatika.text = " + ";
            hasil = angka1 + angka2;
        }

        //ARITMATIKA PENGURANGAN (-)
        else if (aritmatika == 1)
        {
            angka1 = Random.Range(0, 51);
            angka2 = Random.Range(0, 51);
            txt_aritmatika.text = " - ";
            hasil = angka1 - angka2;
        }

        //ARITMATIKA PERKALIAN (*)
        else if (aritmatika == 2)
        {
            angka1 = Random.Range(0, 11);
            angka2 = Random.Range(0, 11);
            txt_aritmatika.text = " X ";
            hasil = angka1 * angka2;
        }

        //ARITMATIKA PEMBAGIAN (:)
        else if (aritmatika == 3)
        {
            int element = Random.Range(0, soal_angka1.Length);
            angka1 = soal_angka1[element];
            angka2 = soal_angka2[element];
            txt_aritmatika.text = " : ";
            hasil = angka1 / angka2;

        }

        //float a = Mathf.Round(hasil);
        txt_angka1.text = angka1.ToString();
        txt_angka2.text = angka2.ToString();
        txt_hasil.text = hasil.ToString("0.##");
    }
}
