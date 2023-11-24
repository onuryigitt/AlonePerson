using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public float health;
    public float damage;

   // bool karaktercollider = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D( Collider2D other)

    {
        if (other.tag == "karakter"  /*&& !karaktercollider  */)
        {
           // karaktercollider = true;
            other.GetComponent<karaktersaglik>().getDamage(damage);
        }

    }
    /*private void OnTriggerExit2D(Collider2D collision)      

    {
        if(collision.tag == "karakter")
        {
           // karaktercollider = false;
        }
    }*/
}
