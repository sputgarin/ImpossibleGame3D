using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grindingSparks : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        Debug.Log("SPARKS!!!!");
    }
}
