using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimationControll : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string walk;
    [SerializeField] private string idle;
    [SerializeField] private string dead;
    [SerializeField] private string attack;
    [SerializeField] private string bossHurt;

    public void Move()
    {
        animator.Play(walk);
    }
    public void Idle()
    {
        animator.Play(idle);
    }
    public void Dead()
    {
        animator.Play(dead);
    }
    public void Attack()
    {
        animator.Play(attack);
    }
    public void BossHurt()
    {
        animator.Play(bossHurt);
    }
    public void BossShotHurt()
    {

    }
        
}
