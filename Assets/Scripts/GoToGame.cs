using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToGame : MonoBehaviour
{
    public Dropdown mode;
    public Dropdown map;
    public void GTGame()
    {
        PlayerPrefs.SetString("map", map.value.ToString());
        PlayerPrefs.SetString("mode", mode.value.ToString());
        if(mode.value == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
