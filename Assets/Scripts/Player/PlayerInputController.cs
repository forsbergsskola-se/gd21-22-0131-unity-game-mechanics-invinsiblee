using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    public float moveInput { get; private set; }
    public bool jumpInputDown { get; private set; }
    public bool jumpInputUp { get; private set; }
    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        moveInput = Input.GetAxis("Horizontal");
        jumpInputDown = Input.GetButton("Jump");
        jumpInputUp = Input.GetButtonDown("Jump");
    }

    private void SetCommands()
    {
        commandContainer.walkCommand = moveInput;
        commandContainer.jumpCommand = jumpInputDown;
        commandContainer.jumpCommandUp = jumpInputUp;
    }
}
