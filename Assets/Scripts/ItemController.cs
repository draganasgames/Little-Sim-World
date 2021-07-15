using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Image ItemImage;
    public Text ItemPrice;
    public BagScreen BagScreen;
    public SpriteRenderer PlayerDress;

    public void OnBuyButtonClicked()
    {
        ItemImage = GetComponentInChildren<Image>();
        ItemPrice = GetComponentInChildren<Text>();
        int sumConvert = Convert.ToInt32(ItemPrice.text);
        BagScreen.Counter = BagScreen.PrefabsPosition.childCount;
        BagScreen.Sum += sumConvert;
        BagScreen.SumText.text = BagScreen.Sum.ToString();
        BagScreen.Prefab.GetComponentInChildren<Image>().sprite = ItemImage.sprite;
        BagScreen.Prefab.GetComponentInChildren<Text>().text = ItemPrice.text;
        BagScreen.InstantiatePrefab();
    }
    
    public void OnTryButtonClicked()
    {
        ItemImage = GetComponentInChildren<Image>();
        PlayerDress.sprite = ItemImage.sprite;
    }
}