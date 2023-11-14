using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grindingSparks : MonoBehaviour
{
    private PlayerControllerSimple player;
    private void Start()
    {
        player = FindFirstObjectByType<PlayerControllerSimple>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("SPARKS!!!!");
        player.PlaySparksEffect();
    }

    private void OnCollisionStay(Collision other)
    {

    }

    private void OnCollisionExit(Collision other)
    {
         player.StopSparksEffect();
    }
}
