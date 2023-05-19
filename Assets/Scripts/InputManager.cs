using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMovement playerMovement;
    private PlayerLook playerLook;
    public PlayerInput.OnFootActions onFoot;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        playerMovement = GetComponent<PlayerMovement>();
        playerLook= GetComponent<PlayerLook>();
        onFoot.Jump.performed += ctx => playerMovement.Jump();
    }

    
    void FixedUpdate()
    {
        playerMovement.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        playerLook.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }

}
