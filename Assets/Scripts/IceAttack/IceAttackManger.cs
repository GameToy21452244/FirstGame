using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAttackManger : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip IceAgeClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")|| collision.CompareTag("Boss"))
          {
            collision.GetComponent<Damageable>().TakeDamage(5);
        }
     }
    public void iceAttackSFX()
    {
        audioSource.PlayOneShot(IceAgeClip);
    }

}
