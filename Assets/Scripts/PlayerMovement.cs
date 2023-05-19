using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 5.0f;
    public float jumpHeighy = 2.0f;
    public float gravity = -9.8f;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        isGrounded = characterController.isGrounded;
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -1.0f;
        }
        characterController.Move(playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if(isGrounded) 
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeighy * -2.0f * gravity);
        }
    }

}
