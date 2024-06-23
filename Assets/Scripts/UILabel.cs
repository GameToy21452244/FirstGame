using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILabel : MonoBehaviour
{
    public static UILabel Instance;
    public TextMeshProUGUI closedEnemyCountText;
    public int KillCount=0;
   public GUIStyle labelFont = new GUIStyle();
    //GUIStyle style;
    
    private void Update()
    {
            closedEnemyCountText.text = ": " + KillCount.ToString();
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
      
    }
    /* public void OnGUI()
     {

         labelFont.normal.textColor = new Color(1, 1, 1);
         labelFont.fontSize = 24;
         GUI.Label(new Rect(60, 11, 200, 40), ":" + KillCount.ToString(), labelFont);
     }*/
}
