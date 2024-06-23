using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;

public class MagieMagicMissileMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private GameObject playerTransform;
    private Vector2 _direction;

    /* private GameObject LocateEnemy()
     {

         var results = new Collider2D[5];
         Physics2D.OverlapCircleNonAlloc(transform.position,10,results);
         foreach(var result in results)
         {
             if (result != null&&result.CompareTag("Enemy"))
             {
                 return result.gameObject;
             }
         }
         return null;
     }
     private Vector2 MoveDirection(Transform target)
     {
         var direction = new Vector2(1, 0);

         if(target != null)
         {
             direction =target.position - transform.position;//目的地減掉初始地
             direction.Normalize();
         }
         return direction;
     }
     private void Awake()
     {
         var enemy =LocateEnemy();
         if (enemy == null)
         {
             _direction = MoveDirection(null);
         }
         else
         {
             _direction = MoveDirection(enemy.transform);
         }
         transform.rotation = Quaternion.LookRotation(Vector3.forward,_direction);

     }*/
    


    private void FixedUpdate()
    {
        rb.velocity = transform.right * speed;

      //var targetPostion = (Vector2)transform.position + _direction;
       // rb.DOMove(targetPostion, speed).SetSpeedBased();
    }
   /* public void Move(InputAction.CallbackContext context)
    {

        _direction = context.ReadValue<Vector2>();


    }
    private Vector2 MoveDirection(Transform target)
    {
        var direction = new Vector2(1, 0);

        if (target != null)
        {
            direction = target.position - transform.position;//目的地減掉初始地
            direction.Normalize();
        }
        return direction;
    }
    private void Awake()
    {

        if (_direction == null)
        {
            _direction = MoveDirection(null);
        }
        else
        {
            _direction = MoveDirection(_direction);
        }
        transform.rotation = Quaternion.LookRotation(Vector3.forward, _direction);

    }*/
}
