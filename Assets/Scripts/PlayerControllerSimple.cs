using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControllerSimple : MonoBehaviour
{
    public float forwardSpeed = 0.05f;
    public int force = 5;
    private float horizontalInput;
    public float sideSpeed;
    private Vector3 movedirection;

    public Rigidbody rb;
    
    
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,forwardSpeed  * Time.deltaTime);
        JumpUp();
    }
    
    public void JumpUp()
    {

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping");
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Force);
        }
    }

    public void Move()
    {
        
        if (Input.GetKeyDown((KeyCode.A)))
        {
            rb.velocity = new Vector3("Left", 0, 0);
        }
        if (Input.GetKeyDown((KeyCode.D)))
        {
            rb.velocity = new Vector3(sideSpeed, 0, 0);
        }
    }
    
    
}
