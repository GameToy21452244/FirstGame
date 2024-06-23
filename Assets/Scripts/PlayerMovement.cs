using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private float speed;
    [SerializeField] private int jumpCount=1;
    [SerializeField] private float jumpForce =700.0f;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private Transform healthUI;
   // [SerializeField] private Transform skillUI;
    private Vector2 _inputDirection;//方向
    Vector2 position;
    float getHorizontal;
    public bool isOnGround;
    bool jumpPress;
    float inputDirection;
    float backPower =100f;
   public bool bossAttack=false;

     /*/public void Move(InputValue context)
     {

        _inputDirection = context.Get<Vector2>();

     }*/
    /* private void Move()
     {
         var position = (Vector2)transform.position;
         var targetPosition = position + _inputDirection;
          if (Input.GetAxis("Horizontal") < 0)
          {
              transform.Rotate(0f, 180f, 0f);

          }


         //rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), rb.velocity.y);





         //if (position == targetPosition) return;
         //rb.DOMove(targetPosition, speed).SetSpeedBased();

     }*/
   private void Update()
    {

         Jump();
        inputDirection = Input.GetAxis("Horizontal");
        float targetSpeed = inputDirection * speed; 
      
        rb.velocity = new Vector2(targetSpeed, rb.velocity.y);

        if (inputDirection < 0)
        {
            shotPoint.eulerAngles = new Vector3(0, 180, 0);
           healthUI.eulerAngles = new Vector3(0, 180, 0);
            //skillUI.localScale = new Vector3(-1, 1, 1);
        }
        else if(inputDirection>0)
        {
            shotPoint.eulerAngles = Vector3.zero;
           healthUI.eulerAngles = Vector3.zero;
           // skillUI.localScale = new Vector3(1, 1, 1);
        }


    }

    void Jump()
    {
        //在地面上跳跃
        if(Input.GetButtonDown("Jump") && isOnGround)
        {

            //rb.AddForce(Vector2.up * jumpForce);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            isOnGround = false;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bossAttack==true)
        {
            if (transform.position.x >= collision.transform.position.x)
            {
                //向左反弹
                rb.velocity = new Vector2(backPower, rb.velocity.y);
                bossAttack = false;
            }
            //右侧同理
            if (transform.position.x <= collision.transform.position.x)
            {
                //向右反弹
                rb.velocity = new Vector2(-backPower, rb.velocity.y);
                bossAttack = false;
            }
            
        }
        
        

    }
}
