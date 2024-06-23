using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSlashMager : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;



    private void Update()
    {

        rb.velocity = transform.right * speed;
     
            Destroy(gameObject,2);

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")|| collision.CompareTag("Boss"))
        {
            collision.GetComponent<Damageable>().TakeDamage(2);


        }
    }
}
