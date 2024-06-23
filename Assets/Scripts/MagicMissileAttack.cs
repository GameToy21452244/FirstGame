using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class MagicMissileAttack : MonoBehaviour
{
    [SerializeField] private UnityEvent attack;
    private void DealDamage(Collider2D other)
    {

        if (other.CompareTag("Enemy") || other.CompareTag("Boss"))//�T�{������H�O���O���a
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            attack.Invoke();
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }
}
