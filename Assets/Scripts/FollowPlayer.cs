using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private void LateUpdate()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 target = player.transform.position + new Vector3(0f, 0.71f, -2.991f);
        transform.position = target;
    }
}
