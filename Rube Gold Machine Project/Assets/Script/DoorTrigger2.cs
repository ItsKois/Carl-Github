using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger2 : MonoBehaviour
{
    [SerializeField]
    GameObject door2;

    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
            door2.transform.position += new Vector3(0, 4, 0);
        }
    }
}