using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class KapıAcilis : MonoBehaviour
{


    public Text scoreText;
    public GameObject cage;

    private void Update()
    {
        if (scoreText.text == "0")
        {
            cage.GetComponent<EdgeCollider2D>().enabled = true;
        }
    }

}
