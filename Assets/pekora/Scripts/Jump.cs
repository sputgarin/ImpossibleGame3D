using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Jump : MonoBehaviour
{
    public int force = 5;

    public void JumpUp()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping");
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Force);
        }
    }

    private void Update()
    {
        JumpUp();
    }
}
