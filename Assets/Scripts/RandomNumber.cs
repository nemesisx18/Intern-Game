using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomNumber : MonoBehaviour
{

    public TextMeshProUGUI txt_angka1;
    public TextMeshProUGUI txt_angka2;
    public TextMeshProUGUI txt_angka3;
    public TextMeshProUGUI txt_aritmatika;
    public TextMeshProUGUI txt_hasil;
    public TMP_InputField txt_input;
    public Text txt_jawaban;

    public Button_0 button;
    public GameTimer gmTimer;

    public AudioSource audio;
    private AudioSource audioSalah;
    public AudioClip clip;
    public AudioClip clipSalah;

    public GameObject changeNameButton;
    public GameObject[] buttonAnswer;

    public SpriteMaster jawaban;
    

    double angka1, angka2, angka3 ,aritmatika;

    public double hasil, inputJawaban;

    public double[] soal_angka1;
    public double[] soal_angka2;


    private void Start()
    {
        RandomNumberAll();
        //RandomAnswer();
        audio.clip = clip;

        audioSalah = gameObject.AddComponent<AudioSource>();
        audioSalah.clip = clipSalah;
    }

    private void Update()
    {
        //Checking Answers
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
            gmTimer.jawabanInput = "";
            StartCoroutine(jawabBenar());
            gmTimer.timeRemaining += 5f;
            gmTimer.AddScore();
            audio.Play();

        }
        else if (inputJawaban != hasil)
        {
            StartCoroutine(jawabSalah());
            gmTimer.jawabanInput = "";
            gmTimer.timeRemaining += 0f;
            audioSalah.Play();
            //gmTimer.AddScore();

        }

    }

    IEnumerator jawabBenar()
    {
        yield return new WaitForSecondsRealtime(2f);
        txt_jawaban.text = "JAWABAN"; 
        RandomNumberAll();
    }

    IEnumerator jawabSalah()
    {
        audioSalah.Play();
        yield return new WaitForSecondsRealtime(1f);
        txt_jawaban.text = "JAWABAN";
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
            RandomButtonAnswer();
        }
        else if (gmTimer.levelSelect == 2)
        {
            aritmatika = Random.Range(0, 2);
            AritmatikaMethod();
            RandomButtonAnswer();
        }
        else if (gmTimer.levelSelect == 3)
        {
            aritmatika = Random.Range(0, 3);
            AritmatikaMethod();
            RandomButtonAnswer();
        }
        else if (gmTimer.levelSelect == 4)
        {
            aritmatika = Random.Range(0, 4);
            AritmatikaMethod();
            RandomButtonAnswer();
        }
        
    }

    public void RandomButtonAnswer()
    {
        
        int a = Random.Range(0, buttonAnswer.Length);

        changeNameButton = buttonAnswer[a];
        changeNameButton.name = hasil.ToString();
        ChangeSprites();
    }

    private void ChangeSprites()
    {
        for (int i = 0; i < jawaban.spriteHasil.Count; i++)
        {
            if (hasil == jawaban.spriteHasil[i].hasil)
            {
                changeNameButton.GetComponent<Image>().sprite = jawaban.spriteHasil[i].gambar;
            }
        }
    }

    /*public void RandomAnswer(){
        
        for (int i = 0; i < (buttonAnswer.Length - 1); i++)
        {
            int a = Random.Range(-9, 19);
            changeNameButton = buttonAnswer[i];
            changeNameButton.name = a.ToString();
            ChangeSprites();
            
        } return;
    }*/

    private void AritmatikaMethod()
    {
        //ARITMATIKA PENJUMLAHAN (+)
        if (aritmatika == 0)
        {
            angka1 = Random.Range(0, 10);
            angka2 = Random.Range(0, 10);
            txt_aritmatika.text = " + ";
            hasil = angka1 + angka2;
        }

        //ARITMATIKA PENGURANGAN (-)
        else if (aritmatika == 1)
        {
            angka1 = Random.Range(0, 10);
            angka2 = Random.Range(0, 10);
            txt_aritmatika.text = " - ";
            hasil = angka1 - angka2;
        }

        //ARITMATIKA PERKALIAN (*)
        else if (aritmatika == 2)
        {
            angka1 = Random.Range(0, 10);
            angka2 = Random.Range(0, 10);
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
