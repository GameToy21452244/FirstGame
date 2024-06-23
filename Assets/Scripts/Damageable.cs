using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Damageable : MonoBehaviour
{
    
    [SerializeField] private Health health;
    //[SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private UnityEvent getDamaged;
    private Color _defaulColor;

    public void TakeDamage(int damage)
    {
       
        health.DecreaseHealth(damage);       
        //spriteRenderer.DOColor(Color.red,0.2f).SetLoops(2,LoopType.Yoyo).ChangeStartValue(_defaulColor);
        getDamaged.Invoke();
    }   //碰到敵人顯示紅色 白到紅->1個Loop 紅到白 ->一個Loop =2Loop

    public void TakeDamage(int damage,string str)
    {
       //damaged.Invoke();
       // animator.Play(EnemyHurt);
        health.DecreaseHealth(damage);
        //spriteRenderer.DOColor(Color.red, 0.2f).SetLoops(2, LoopType.Yoyo).ChangeStartValue(_defaulColor);
       
            
       
    }

        /*private void Awake()
        {
            _defaulColor = spriteRenderer.color;
        }*/
    }
