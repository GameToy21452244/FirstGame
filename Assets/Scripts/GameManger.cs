using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private GameObject BossPrfab;
    //[SerializeField] private GameObject BossHeathBar;
    bool _canCreate = true;
    void Update()
    {
        if (UILabel.Instance.KillCount == 10&&_canCreate)
        {
                
            
            Instantiate(BossPrfab, new Vector3(0, 0, 0), transform.rotation);
            _canCreate = false;
        }
    }
    
}
