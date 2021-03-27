using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCoin : MonoBehaviour
{
    public int coins=0;
    private int posY=10;
    public int m_PlayerNumber;
    public int needed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI(){
        if (needed == 1) ;
        {
            if (PlayerPrefs.GetString("mode") == "0")
            {
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.fontSize = 20;
                string noTank;
                Debug.Log(m_PlayerNumber);
                if(m_PlayerNumber == 1)
                {
                    noTank = string.Format("<color=blue>{0}</color>", PlayerPrefs.GetString("player" + m_PlayerNumber.ToString()) + " money") ;
                }
                else
                {
                    noTank = string.Format("<color=red>{0}</color>", PlayerPrefs.GetString("player" + m_PlayerNumber.ToString()) + " money");
                }
                GUI.Label(new Rect(10, (posY * m_PlayerNumber * 2), 200, 200), (noTank + " : $" + coins.ToString()), style);
            }
            else
            {
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.white;
                style.fontSize = 20;
                string noTank = "SCORE "+ PlayerPrefs.GetString("player"+ m_PlayerNumber.ToString());
                GUI.Label(new Rect(10, (posY * m_PlayerNumber * 2), 200, 200), (noTank + " : " + coins.ToString()), style);
            }
        }
    }
}
