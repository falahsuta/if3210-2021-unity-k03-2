using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    public InputField player1Name;
    public InputField player2Name;
    public void SetNames()
    {
        if (string.IsNullOrEmpty(player1Name.text.ToString())){
            PlayerPrefs.SetString("player1", "Player 1");
        }
        else
        {
            
            PlayerPrefs.SetString("player1", player1Name.text.ToString());
        }
        if (string.IsNullOrEmpty(player2Name.text.ToString()))
        {
            PlayerPrefs.SetString("player2", "Player 2");
        }
        else
        {
            
            PlayerPrefs.SetString("player2", player2Name.text.ToString());
        }
    }
}
