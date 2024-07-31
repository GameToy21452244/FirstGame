using Spine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Spine.Unity;
using UnityEngine.Events;

public class BossMovement : MonoBehaviour
{
    [SerializeField] private UnityEvent BossAnimationMove;
    [SerializeField] private UnityEvent BossAnimationHurt;
    [SerializeField] private UnityEvent BossAnimationShotHurt;
    [SerializeField] private UnityEvent BossAnimationAttack;
    [SerializeField] private RectTransform HeathBarRect;
    public bool Hurting = false;
    public bool Attacking = false;
    public bool ShotHurt = false;
    private float time = 0f;
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2.0f)
        {
            Attacking = true;

        }
    }
    public void Move(Vector2 direction)
    {
        if (direction.x >= 0&&Hurting==false&&Attacking==false&& ShotHurt==false)
        {
            transform.rotation = quaternion.Euler(0, 0, 0);
            HeathBarRect.rotation = quaternion.Euler(0, 0, 0);
            BossAnimationMove.Invoke();

        }

        else if (direction.x <= 0&&Hurting == false&&Attacking==false&& ShotHurt==false)
        {
            transform.rotation = quaternion.Euler(0, -160, 0);
            HeathBarRect.rotation = quaternion.Euler(0, 0, 0);
            BossAnimationMove.Invoke();
        }
        else if (direction.x >= 0 && Attacking == true)
        {
            BossAnimationAttack.Invoke();
            time = 0;
        }
        else if (direction.x <= 0 && Attacking == true)
        {
            BossAnimationAttack.Invoke();
            time = 0;
        }
        else if (direction.x >= 0 && Hurting == true)
        {
            BossAnimationHurt.Invoke();
        }
        else if (direction.x <= 0 && Hurting == true)
        {
            BossAnimationHurt.Invoke();

        }
        else if (direction.x <= 0 && ShotHurt == true)
        {
            BossAnimationShotHurt.Invoke();
        }
        else if (direction.x >= 0 && ShotHurt == true)
        {
            BossAnimationShotHurt.Invoke();
        }



    }
   
    
     
}
