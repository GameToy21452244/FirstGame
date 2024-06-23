using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDestroy : MonoBehaviour
{
    [SerializeField] Attack attack;
    public int killCount = 0;
    public void Destroy()
    {
        if (killCount >= 2)
        {
            Destroy(gameObject);
            killCount = 0;
        }
        else
        {
            killCount++;
            attack._canAttack = true;
        }
        return;
    }
}
