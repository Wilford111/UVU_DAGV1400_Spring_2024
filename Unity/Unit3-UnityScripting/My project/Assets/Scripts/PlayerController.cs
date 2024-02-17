using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float virticalInput = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontalInput + transform.forward * virticalInput;
        controller.Move(move * moveSpeed * Time.deltaTime);

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
                isJumping = true;
            }

        }
        moveDirection.y += Physics.gravity.y * Time.deltaTime;
        //moveDirection.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (controller.isGrounded && moveDirection.y < 0)
        {
            moveDirection.y = -2f;
        }
        if (isJumping && controller.isGrounded)
        {
            isJumping = false;
        }
    }
}
