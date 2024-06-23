using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceAge : MonoBehaviour
{
    [SerializeField] private GameObject iceAttack;
    [SerializeField] private Animator animator;
    [SerializeField] private string iceAgeState;
    [SerializeField] private Image iceAgeSkillMask;
    private float IceAgeColdTime;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (IceAgeColdTime == 0)
            {
                Instantiate(iceAttack, transform.position, transform.rotation);
                animator.Play(iceAgeState);
                IceAgeColdTime = 4;
            }
        }

        if (IceAgeColdTime > 0)
        {
                IceAgeColdTime -= Time.deltaTime;
                if (IceAgeColdTime < 0)
                {
                    IceAgeColdTime = 0;
                }
                iceAgeSkillMask.fillAmount = IceAgeColdTime / 2;
            }
        }
    
}
