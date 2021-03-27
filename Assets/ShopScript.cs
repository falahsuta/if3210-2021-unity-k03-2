using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public GameObject shopPanel;
    bool show = false;

    public void onClick()
    {
        shopPanel.SetActive(!show);
        show = !show;
    }
}
