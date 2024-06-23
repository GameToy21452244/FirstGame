using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent died;
    [SerializeField] private string targetTag;
    public void ChechDeath(int health)
    {
        if (health <= 0) 
        { 
            Die();
            if (targetTag == "Enemy"||targetTag=="Boss")
            {
                UILabel.Instance.KillCount++;
            }
        }
    }
    public void Die()
    {
            gameObject.SetActive(false);
            died.Invoke();
        
    }
}
