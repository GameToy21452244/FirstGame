using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Em : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private UnityEvent<Vector2> moveDirection;
    //[SerializeField] private PlayerManager playerManager;

    private void FixedUpdate()
    {
        var playerPosition = PlayerManager.Position;
        var postion =(Vector2)transform.position;
        var direction = playerPosition - postion;
        direction.Normalize();
        var targetPosition = postion + direction;
        rb.DOMove(targetPosition, speed).SetSpeedBased();
        moveDirection.Invoke(direction);
    }
}
