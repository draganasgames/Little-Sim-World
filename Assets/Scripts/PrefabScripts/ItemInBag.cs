using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInBag : MonoBehaviour
{
    public Image ItemImage;
    public Text ItemPrice;
    private int _sum = 0;
    private BagScreen _bagScreen;

    public void Initialize(BagScreen bagScreen)
    {
        _bagScreen = bagScreen;
    }

    public void OnCancelButtonClicked()
    {
        Destroy(this.gameObject);
    }

    public void OnBuyButtonClicked()
    {
        ItemImage.sprite = GetComponentInChildren<Image>().sprite;
        ItemPrice.text = GetComponentInChildren<Text>().text;
        _bagScreen.MyClosetScreen.Prefab.GetComponentInChildren<Image>().sprite = ItemImage.sprite;
        _bagScreen.MyClosetScreen.Prefab.GetComponentInChildren<Text>().text = ItemPrice.text;
        _bagScreen.MyClosetScreen.InstantiatePrefab();
        Destroy(this.gameObject);
        int itemConvert = Convert.ToInt32(ItemPrice.text);
        int moneyConvert = Convert.ToInt32(_bagScreen.MoneyNumber.text);
        _sum = moneyConvert - itemConvert;
        _bagScreen.MoneyNumber.text = _sum.ToString();
    }
}