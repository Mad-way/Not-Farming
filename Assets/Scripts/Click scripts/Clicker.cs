using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] int clicks;
    public Text clicksText;
    

    void OnMouseDown()
    {
        if (ShowClicker.mode == ShowClicker.Mode.ClickerMode)
        {
            clicks++;
            clicksText.text = clicks.ToString();
        }
    }


}
