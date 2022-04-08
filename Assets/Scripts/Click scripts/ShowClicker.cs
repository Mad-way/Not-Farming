using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowClicker : MonoBehaviour
{
    [SerializeField]
    private GameObject tractor;
    [SerializeField]
    private GameObject camera2;
    [SerializeField]
    private GameObject joysticks;
    public static Mode mode;


    private void Start()
    {
        ChangeMode();
    }
    public void ChangeMode()
    {
        if (mode == Mode.ClickerMode)
        {
            mode = Mode.TractorMode;
            tractor.SetActive(true);
            joysticks.SetActive(true);
            camera2.SetActive(false);
        }
        else {
            mode = Mode.ClickerMode;
            tractor.SetActive(false);
            joysticks.SetActive(false);
            camera2.SetActive(true);
           
        }
    }

    public enum Mode 
    { 
        TractorMode, ClickerMode
    }
}

