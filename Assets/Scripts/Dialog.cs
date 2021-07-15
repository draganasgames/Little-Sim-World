using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI TextDisplay;
    public string[] Sentences;
    public GameObject ContinueButton;
    public Image DialogImage;
    public float TypingSpeed;
    public GameObject BagScreen;
    public string[] Sentences2;
    public GameObject ContinueButton2;
    private int index;
    private int index2;

    public void StartDialog()
    {
        StartCoroutine(Type());
    }

    public void StartDialog2()
    {
        StartCoroutine(Type2());
    }

    void Update()
    {
        if (TextDisplay.text == Sentences[index])
        {
            ContinueButton.SetActive(true);
        }

        if (TextDisplay.text == Sentences2[index2])
        {
            ContinueButton2.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in Sentences[index].ToCharArray())
        {
            TextDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Type2()
    {
        foreach (char letter in Sentences2[index2].ToCharArray())
        {
            TextDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence()
    {
        ContinueButton.SetActive(false);
        if (index < Sentences.Length - 1)
        {
            index++;
            TextDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            TextDisplay.text = "";
            ContinueButton.SetActive(false);
            DialogImage.gameObject.SetActive(false);
            index = 0;
        }
    }

    public void NextSentence2()
    {
        ContinueButton2.SetActive(false);
        if (index2 < Sentences2.Length - 1)
        {
            index2++;
            TextDisplay.text = "";
            StartCoroutine(Type2());
        }
        else
        {
            TextDisplay.text = "";
            ContinueButton2.SetActive(false);
            DialogImage.gameObject.SetActive(false);
            index2 = 0;
            BagScreen.SetActive(true);
        }
    }
}