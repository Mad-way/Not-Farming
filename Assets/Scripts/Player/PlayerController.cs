using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Joystick joystick;
    public float speed = 7f;
    public Rigidbody rb;


    private float vertical;
    void Update()
    {
        GetMobileInput();
    }

    private void GetMobileInput()
    {
        vertical = joystick.Vertical;
        if (vertical >= 0.5f)
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }       
    }
}