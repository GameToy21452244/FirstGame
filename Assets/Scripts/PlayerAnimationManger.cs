using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerAnimationManger : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer BodySpriteRenderer;
    [SerializeField] private SpriteRenderer LeftLegegSpriteRenderer;
    [SerializeField] private SpriteRenderer RightLegegSpriteRenderer;
    [SerializeField] private SpriteRenderer attackPoint;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;
    [SerializeField] private string attackState;
    [SerializeField] private string hurtState;    



    public void Move(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction == Vector2.zero)
        {
            animator.Play(idleState);

        }
        else
        {
            animator.Play(walkState);
        }
        
        if (direction.x > 0)
        {
            transform.localScale = Vector3.one;
            attackPoint.flipX = false;
        }
        else if (direction.x < 0)
        {
            //animator.Play(TurnLeft);
            transform.localScale = new Vector3(-1f, 1f, 1f);
            attackPoint.flipX = true;
        }

    }

    public void MagicAttack()
    {
        animator.Play(attackState);
        return;
    }
    public void HurtState()
    {
        animator.Play(hurtState);
    }
    public void GunFire()
    {
        attackPoint.flipX = false;
        animator.Play(attackState);
    }
}
