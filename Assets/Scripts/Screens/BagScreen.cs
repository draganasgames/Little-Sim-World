using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagScreen : MonoBehaviour
{
    public GameObject Prefab;
    public Transform PrefabsPosition;
    public MyClosetScreen MyClosetScreen;
    public int Sum;
    public Text SumText;
    public int Counter;
    public Text MoneyNumber;

    public void InstantiatePrefab()
    {
        var item = Instantiate(Prefab, PrefabsPosition).GetComponent<ItemInBag>();
        item.Initialize(this);
    }
    public void OnCloseButtonClicked()
    {
        this.gameObject.SetActive(false);
    }
}