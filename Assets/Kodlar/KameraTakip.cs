using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public GameObject Karakter;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - Karakter.transform.position;
    }


    void Update()
    {
        transform.position = Karakter.transform.position + mesafe;
    }
}
