using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMenager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerMovement playerMovement;
    private PlayerLook playerLook;

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
