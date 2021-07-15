using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BagScreen;
    public GameObject MyClosetScreen;
    public GameObject ClothesScreen;

    public void OnBagButtonClicked()
    {
        BagScreen.SetActive(true);
        ClothesScreen.SetActive(false);
        MyClosetScreen.SetActive(false);
    }

    public void OnMyClosetButtonClicked()
    {
        MyClosetScreen.SetActive(true);
        BagScreen.SetActive(false);
        ClothesScreen.SetActive(false);
    }
}