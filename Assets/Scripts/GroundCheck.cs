using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    [SerializeField] private string targetTag;
    //[SerializeField] public PlayerMovement CheckGround;

     [SerializeField] PlayerMovement playerMovement;
    [SerializeField] PlayerMovement SwordManMovement;
    [SerializeField] PlayerMovement GunerMovement;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            playerMovement.isOnGround = true;
            SwordManMovement.isOnGround = true;
            GunerMovement.isOnGround = true;

        }
        
    }

}
