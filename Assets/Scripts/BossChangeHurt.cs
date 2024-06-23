using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChangeHurt : MonoBehaviour
{
    public BossMovement bossMovement;
    public void ChangeHurtBoss()
    {
        bossMovement.Hurting = false;
    }
    public void ChangeAttackingBoss()
    {
        bossMovement.Attacking = false;
    }
}
