using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemApple : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string targetTag;
    [SerializeField] private Health health;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag(targetTag))
        {
            health.IncreaseHealth(5);
            Destroy(collision.gameObject);
        }
        
    }
}
