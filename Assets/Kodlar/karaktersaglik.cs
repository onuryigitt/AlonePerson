using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karaktersaglik : MonoBehaviour
{
    public float health;

    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getDamage(float damage)
    {
        if(health - damage >= 0 )
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        amIdead();

    }
    void amIdead()
    {
        if(health == 0)
        {
            dead = true;
        }
    }
}
