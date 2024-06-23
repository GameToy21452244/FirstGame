using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChearterSelection : MonoBehaviour
{
    CharacterManger characterManger;
    [SerializeField] GameObject Master;
    [SerializeField] GameObject SwordMan;
    [SerializeField] GameObject MasterUI;
    [SerializeField]GameObject SwordManUI;
    public void Start()
    {

        if (PlayerPrefs.GetInt("selectionIndex") % 2==1)
        {
           // Master.SetActive(true);
            //MasterUI.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("selectionIndex")% 2== 0)
        {
            //SwordMan.SetActive(true);
            //SwordManUI.SetActive(true);

        }

    }

}
