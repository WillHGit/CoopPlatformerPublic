using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveDirection;
    private float movementSpeed = 1f;
    private float jumpForce = 2.5f;
    private bool isFacingRight = true;
    public Animator characterAnimator;
    [SerializeField] private Rigidbody2D playerRigidbody;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask obstacleLayer;

    void Update()
    {
        HandleAnimation();
        HandleMovementInput();
        CheckForJump();
        FlipCharacter();
    }

    private void HandleAnimation()
    {
        characterAnimator.SetBool("IsJumping", !IsGrounded());
        characterAnimator.SetBool("IsPushing", IsPushing());
        characterAnimator.SetFloat("Speed", Mathf.Abs(moveDirection));
    }

    private void HandleMovementInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDirection = -1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveDirection = 1;
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            moveDirection = 0;
        }

        playerRigidbody.velocity = new Vector2(moveDirection * movementSpeed, playerRigidbody.velocity.y);
    }

    private void CheckForJump()
    {
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded())
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, jumpForce);
        }

        if (Input.GetKeyUp(KeyCode.W) && playerRigidbody.velocity.y > 0f)
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, playerRigidbody.velocity.y * 0.5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.15f, groundLayer);
    }

    private bool IsPushing()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.15f, obstacleLayer);
    }

    private void FlipCharacter()
    {
        if ((isFacingRight && moveDirection < 0f) || (!isFacingRight && moveDirection > 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}