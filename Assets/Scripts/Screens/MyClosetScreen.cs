using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyClosetScreen : MonoBehaviour
{
    public GameObject Prefab;
    public Transform PrefabsPosition;
    public Text MoneyNumber;

    public void InstantiatePrefab()
    {
        var item = Instantiate(Prefab, PrefabsPosition).GetComponent<MyItemClothes>();
        item.Initialize(this);
    }

    public void OnCloseButtonClicked()
    {
        this.gameObject.SetActive(false);
    }
}