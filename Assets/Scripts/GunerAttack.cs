using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunerAttack : MonoBehaviour
{
    [SerializeField] private UnityEvent ShotFire;
    [SerializeField] private UnityEvent FireSFX;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {

            ShotFire.Invoke();
            FireSFX.Invoke();

        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            col.GetComponent<EnemyAnimarorCt>().ShotHurting = true;
            col.GetComponent<Damageable>().TakeDamage(1);
            
        }
        if (col.CompareTag("Boss"))
        {
            col.GetComponent<BossMovement>().ShotHurt = true;
            col.GetComponent <Damageable>().TakeDamage(1);
        }
    }
}
