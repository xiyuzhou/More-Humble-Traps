using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour, ICharacterMover
{
    public int Health { get; set; }

    public bool IsMatColor { get; set; }

    private CharacterController characterController;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public bool isJumping { get; set; }

    public Material oriMat;
    private Vector3 moveDirection = Vector3.zero;
    void Awake
        ()
    {
        characterController = GetComponent<CharacterController>();
        oriMat = this.GetComponent<Renderer>().material;
        isJumping = false;
        IsMatColor = false;
    }
    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                jump();
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        if (isJumping)
        {
            isJumping = false;
            jump();
            Debug.Log("jumop");
        }
        if (IsMatColor)
        {
            IsMatColor = false;
            if (oriMat.color == Color.white)
            {
                oriMat.color = Color.red;
            }
            else
            {
                oriMat.color = Color.white;
            }
        }
        characterController.Move(moveDirection * Time.deltaTime);
    }
    public void jump()
    {
        moveDirection.y = jumpSpeed;
        moveDirection.y -= gravity * Time.deltaTime;

    }

}