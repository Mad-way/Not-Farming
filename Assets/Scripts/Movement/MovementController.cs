using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour

{
    [SerializeField] private VariableJoystick variableJoystick;
    [SerializeField] private Rigidbody player;
    private float inputForward = 0;
    public float speed = 5f, speedRotation = 15f;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void SetInputForward(float input) {
        inputForward = input;

    }
    // Update is called once per frame
    void Update()
    {
        player.MovePosition(player.position + player.transform.forward * inputForward * speed * Time.deltaTime);
        
#if UNITY_EDITOR
        player.MoveRotation(Quaternion.Euler(0, player.rotation.eulerAngles.y + variableJoystick.Horizontal * speedRotation * Time.deltaTime, 0));
#else
        player.MoveRotation(Quaternion.Euler(0, player.rotation.eulerAngles.y + variableJoystick.Horizontal * speedRotation * inputForward * Time.deltaTime, 0));
#endif

    }


}
