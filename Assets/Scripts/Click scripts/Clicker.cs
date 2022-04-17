using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public static int clicks;
    public Text clicksText;

    public static UnityEvent Click = new UnityEvent();
    void OnMouseDown()
    {
        if (ShowClicker.mode == ShowClicker.Mode.ClickerMode)
        {
            clicks++;
            clicksText.text = clicks.ToString();
            Click?.Invoke();
        }
    }


}
