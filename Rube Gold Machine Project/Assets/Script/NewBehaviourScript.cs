using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Range(100, 10000)]
    public float bounceheight;

    private void OnCollisionEnter(Collision collission)
    {
        GameObject bouncer = collission.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceheight);
    }
}
