using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwordManPlayerAnimationManger : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer attackPoint;
    [SerializeField] private string walkState;
    [SerializeField] private string idleState;

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
}
