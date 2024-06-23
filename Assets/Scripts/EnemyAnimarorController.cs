using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAnimarorCt : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] private string moveState;
    [SerializeField] private string hurtState;
    [SerializeField] private string ShotHurtingState;
    
     public bool Hurting = false;
     public bool ShotHurting = false;

    
    public void Move(Vector2 direction)
    {
        if (direction.x >= 0&&Hurting==false&&ShotHurting==false)
        {
            transform.rotation = quaternion.Euler(0, 0, 0);
            animator.Play(moveState);
        }
        else if(direction.x<=0&& Hurting==false&&ShotHurting==false)
        {
            transform.rotation = quaternion.Euler(0, -160, 0);
            animator.Play(moveState);
        }
        else if (direction.x>=0 && Hurting == true)
        {
            animator.Play(hurtState);
        }
        else if (direction.x <=0 && Hurting == true)
        {
            animator.Play(hurtState);
        }
        else if (direction.x >= 0 && ShotHurting == true)
        {
            animator.Play(ShotHurtingState);
        }
        else if (direction.x <= 0 && ShotHurting == true)
        {
            animator.Play(ShotHurtingState);
        }


    }
    public void Hurt()
    {
        animator.Play(hurtState);

    }

}
