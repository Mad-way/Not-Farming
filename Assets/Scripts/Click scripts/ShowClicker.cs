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
    [SerializeField]
    private GameObject clickText;
<<<<<<< Updated upstream
=======
    [SerializeField]
    private GameObject forwardButton;
>>>>>>> Stashed changes
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
            forwardButton.SetActive(true);
            tractor.SetActive(true);
            joysticks.SetActive(true);
            camera2.SetActive(false);
            clickText.SetActive(false);
        }
        else {
            mode = Mode.ClickerMode;
            forwardButton.SetActive(false);
            tractor.SetActive(false);
            joysticks.SetActive(false);
            camera2.SetActive(true);
            clickText.SetActive(true);
        }
    }

    public enum Mode 
    { 
        TractorMode, ClickerMode
    }
}

