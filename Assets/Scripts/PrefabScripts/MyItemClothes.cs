using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyItemClothes : MonoBehaviour
{
    public Image MyItemImage;
    public Text MyItemPrice;
    private int _sum = 0;
    private MyClosetScreen _myClosetScreen;

    public void Initialize(MyClosetScreen myClosetScreen)
    {
        _myClosetScreen = myClosetScreen;
    }

    public void OnDressButtonClicked()
    {
        MyItemImage = GetComponentInChildren<Image>();
    }

    public void OnSellButtonClicked()
    {
        MyItemPrice.text = GetComponentInChildren<Text>().text;
        int itemConvert = Convert.ToInt32(MyItemPrice.text);
        int moneyConvert = Convert.ToInt32(_myClosetScreen.MoneyNumber.text);
        _sum = moneyConvert + itemConvert;
        _myClosetScreen.MoneyNumber.text = _sum.ToString();
        Destroy(this.gameObject);
    }
}