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
    public WeaponSwap swapWeapon;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        playerMovement = GetComponent<PlayerMovement>();
        playerLook = GetComponent<PlayerLook>();
        swapWeapon = GetComponent<WeaponSwap>();
        onFoot.Jump.performed += ctx => playerMovement.Jump();
        onFoot.Sprint.performed += ctx => playerMovement.Sprint();
        onFoot.Crouch.performed += ctx => playerMovement.Crouch();
        onFoot.WeaponSwap.performed += ctx => swapWeapon.SwapWeapon();
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
