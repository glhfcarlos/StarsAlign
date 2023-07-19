using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public Rigidbody2D rb; 
    Vector2 movement; 
    public Animator animator; 

    // Update is called once per frame
    void Update()
    {
        // Get the movement input from the Xbox controller
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Assign the input values to the movement vector
        movement.x = horizontalInput;
        movement.y = verticalInput;

        // Set the animator parameters for controlling animations
        animator.SetFloat("Horizontal", horizontalInput); 
        animator.SetFloat("Vertical", verticalInput);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Move the player's Rigidbody based on the movement input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}


