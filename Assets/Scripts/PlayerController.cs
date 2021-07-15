using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    public GameObject obj1;
    public Dialog Dialog;
    public Image DialogObject;

    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += Speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= Speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= Speed * Time.deltaTime;
        }
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Clothes")
        {
            obj1.SetActive(true);
        }
        if(collision.gameObject.tag == "SALESPERSON")
        {
            DialogObject.gameObject.SetActive(true);
            Dialog.TextDisplay.text = "";
            Dialog.StartDialog();
        }
        if (collision.gameObject.tag == "CashRegister")
        {
            DialogObject.gameObject.SetActive(true);
            Dialog.TextDisplay.text = "";
            Dialog.StartDialog2();

        }
    }
}