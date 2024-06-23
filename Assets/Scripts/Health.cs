using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private UnityEvent<int> healthChanged;
    bool isFullBlood = true;

    public int Value
    {
        get { return health; }
    }

    public void DecreaseHealth(int amout)
    {
        health -= amout;
        healthChanged.Invoke(health);
    }

    public void IncreaseHealth(int amout)
    {
        if (isFullBlood == false)
        {
            if (health + amout > 20)
            {
                health = 20;
             
            }
            else
            {
                health += amout;              
            }
            healthChanged.Invoke(health);
        }
    }
    private void Update()
    {
        if (health == 20)
        {
            isFullBlood = true;
        }
        else
        {
            isFullBlood = false;
        }

    }
}
