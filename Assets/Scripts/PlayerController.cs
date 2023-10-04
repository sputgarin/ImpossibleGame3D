using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 0.05f;
    public float moveSpeed = 5f;
    public float jumpForce = 100f;
    
    private Rigidbody rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
         Debug.Log("Jumping");
         rb.AddForce(Vector3.up * jumpForce * rb.mass, ForceMode.Impulse);
       
        
    }

    private void FixedUpdate()
    {
        // transform.Translate(0,0,forwardSpeed  * Time.deltaTime);
        rb.velocity = new Vector3(moveInput.x * moveSpeed, 0, rb.velocity.z);
    }

    public void Move(InputAction.CallbackContext context)
    {
        // Read the input value from the context.
        moveInput = context.ReadValue<Vector2>();
    
        // Apply the movement logic based on the input.
        // Use moveInput.x for horizontal movement and moveInput.y for vertical movement.
        
        // Log a message for testing purposes.
         Debug.Log("Horizontal Input: " + moveInput.x);
         Debug.Log("Vertical Input: " + moveInput.y);
    }
    
}
