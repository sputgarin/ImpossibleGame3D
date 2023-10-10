using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour
{
 public float jumpForce = 10;

 private void OnTriggerEnter(Collider other)
 {
     Rigidbody rb = other.GetComponent<Rigidbody>();
     Vector3 velocity = rb.velocity;
     velocity.y = jumpForce;
     rb.velocity = velocity;
 }
}
