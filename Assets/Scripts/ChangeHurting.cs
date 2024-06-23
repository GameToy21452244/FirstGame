using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHurting : MonoBehaviour
{
    public EnemyAnimarorCt enemyAnimaror;



    public void ChangeHurt()
    {
        enemyAnimaror.Hurting = false;
    }
    public void ChangeShotHurt()
    {
        enemyAnimaror.ShotHurting = false;
    }
    
}
