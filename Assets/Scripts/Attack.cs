using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Timers;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attack;
    public bool _canAttack=true;
    public bool _Destroy = false;
    private float timer = 0;
    private float overTime = 3.0f;


    private void OnTriggerEnter2D(Collider2D col)
    {
        DealDamage(col);
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }

    private void DealDamage(Collider2D other)
    {
        if (!_canAttack) return;

        if (other.CompareTag(targetTag))//確認攻擊對象是不是玩家
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;          
            attack.Invoke();
            
        }
        
    }
    private void CanAttack()
    {
        _canAttack = true;
    }
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer>=overTime)
        {
            attack.Invoke();
            timer = 0;
        }
    }

}
