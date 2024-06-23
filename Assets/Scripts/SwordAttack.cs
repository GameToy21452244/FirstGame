using System.Collections;
using System.Collections.Generic;
using Timers;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SwordAttack : MonoBehaviour
{

    [SerializeField] private string targetTag;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private string attackState;
    [SerializeField] private string attackState2;
    [SerializeField] private string attackState3;
    [SerializeField]private string SlashQIState;
    [SerializeField] private string SlashQIBeforeState;
    [SerializeField] private string GroundSlashState;
    [SerializeField] public Transform attackPointTransform;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip AttackSFX;
    [SerializeField] private AudioClip SlashQISFX;
    [SerializeField] private AudioClip GroundSlahChip;
    [SerializeField] public EnemyAnimarorCt enemyAnimaror;
    [SerializeField] private GameObject prefabGroundSlash;
    [SerializeField] private Image SkillGroundSlash;

    private float GroundSlashSpeed = 10.0f;
    private float KeyKHoldTime=0.1f;
    public float attackRange=0.5f;
    private float dashingPower =250f;
    private float dashingTime = 0f;
    private float dashingColdown = 0.1f;
    private float groundSlashColdTime=0;
    public LayerMask enemyLauers;
    int AttackCount = 0;
    private bool canDash = true;
    private bool isDashing;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.K) && KeyKHoldTime <=0)
      {
           //StartCoroutine(SlashQI());
          dash();
          audioSource.PlayOneShot(SlashQISFX);
            //canDash = false;
      }

     
   

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
      {
          animator.Play(SlashQIBeforeState);
            //canDash = true;
          KeyKHoldTime -= Time.deltaTime;


      }

        /*if (Input.GetKeyUp(KeyCode.K) && KeyKHoldTime <= 0)
        {
             //StartCoroutine(SlashQI());
            dash();
            audioSource.PlayOneShot(SlashQISFX);
        }*/

       /* if (Input.GetKey(KeyCode.K))
        {
            animator.Play(SlashQIBeforeState);
            KeyKHoldTime -= Time.deltaTime;


        }*/


        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
            audioSource.PlayOneShot(AttackSFX);
        }
        

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (groundSlashColdTime == 0)
            {
                Instantiate(prefabGroundSlash, attackPointTransform.position, attackPointTransform.rotation);
                animator.Play(GroundSlashState);
                audioSource.PlayOneShot(GroundSlahChip);
                groundSlashColdTime = 3.0f;
            }

        }
        if (groundSlashColdTime > 0)
        {
            groundSlashColdTime -= Time.deltaTime;
            if (groundSlashColdTime < 0)
            {
                groundSlashColdTime = 0;
            }
            SkillGroundSlash.fillAmount = groundSlashColdTime / 2;
        
    
        }

}
    IEnumerator SlashQI()//Dash Attack
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(playerTransform.localScale.x * dashingPower, 0f);
        animator.Play(SlashQIState);
        yield return new WaitForSeconds(dashingTime);
       
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingColdown);
        canDash = true;
        
    }
    void dash() {
        float originalGravity = rb.gravityScale;
       // rb.gravityScale = 0f;
        rb.velocity = new Vector2(playerTransform.localScale.x * dashingPower, 0f);
        Debug.Log(rb.velocity);
        animator.Play(SlashQIState);

        rb.gravityScale = originalGravity;
        canDash = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)//K Attack
    {
        if (collision.CompareTag("Enemy"))
        {
            //collision.GetComponent<EnemyAnimarorCt>().Hurt();
            collision.GetComponent<EnemyAnimarorCt>().Hurting=true;
            
            collision.GetComponent<Damageable>().TakeDamage(1, "SwordQI");
            
        }
        if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<BossMovement>().Hurting = true;
            collision.GetComponent<Damageable>().TakeDamage(1);
        }
    }
    void Attack()
    {
        if(AttackCount == 0)
        {
            animator.Play(attackState);
            AttackCount++;
        }
        else if(AttackCount == 1) 
        {
            animator.Play(attackState2);
            AttackCount++;
        }
        else
        {
            animator.Play(attackState3);
            AttackCount = 0;
        }
        
        Collider2D[]hitEnemies=Physics2D.OverlapCircleAll(attackPointTransform.position,attackRange,enemyLauers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Damageable>().TakeDamage(1);
        }
    }

   private void OnDrawGizmosSelected()
    {
        if(attackPointTransform == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPointTransform.position, attackRange);
    }
}
