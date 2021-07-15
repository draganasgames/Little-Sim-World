using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesScreen : MonoBehaviour
{
    public void OnCloseButtonClicked()
    {
        this.gameObject.SetActive(false);
    }
}