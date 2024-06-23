//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Timers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator creator;
    [SerializeField] private UnityEvent missileLaunch;
    [SerializeField] private UnityEvent LaserBallLaunch;
    [SerializeField] private UnityEvent FireBallLaunch;
    [SerializeField] private Image SkillMask;
    private float FireBallCooldown = 1f;
    private float LaserColdTime;
    private float timer = 0;
    public bool isStartRun=true;
    
    private void LaunchMissile()
    {
        creator.CreaterMisslie();
    }
    private void LaunchFireBall()
    {
        creator.CreaterFireBall();
    }
    private void LaunchLaserBall()
    {
     
            creator.CreaterLaserBall();
      
        
        
    }
    private void Update()
    {
              
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (LaserColdTime == 0)
                {
                    LaunchLaserBall();
                    LaserBallLaunch.Invoke();
                    LaserColdTime = 2;
                }
           
            }
        

        if (LaserColdTime > 0)
        {
            LaserColdTime -= Time.deltaTime;
            if(LaserColdTime < 0)
            {
                LaserColdTime = 0;
            }
            SkillMask.fillAmount = LaserColdTime / 2;
        }
        if (Input.GetKey(KeyCode.J))
        {
            FireBallCooldown -= Time.deltaTime;  
           
        }

        if (Input.GetKeyUp(KeyCode.J) && FireBallCooldown <= 0f)
        {
            LaunchFireBall();
            FireBallCooldown = 1f;//按住一秒後發射出火球
            FireBallLaunch.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            LaunchMissile();
            missileLaunch.Invoke();
            
        }
        
    }

   
    /*private void Awake()
    {
        //LaunchMissile();

        TimersManager.SetLoopableTimer(this, 1, LaunchMissile);
        
    }*/
}
