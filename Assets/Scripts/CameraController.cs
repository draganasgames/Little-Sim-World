using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform targer;

    void Update()
    {
        transform.position = new Vector3(targer.transform.position.x, targer.transform.position.y, transform.position.z);
    }
}