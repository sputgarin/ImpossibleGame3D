using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggButton : MonoBehaviour
{
    public GameObject engineFire;
    public void HoverStart()
    {
        //transform.localScale = Vector3.one * 100.1f;
        engineFire.SetActive(true);
    }

    public void HoverEnd()
    {
        engineFire.SetActive(false);
        //transform.localScale = Vector3.one;
    }

    public void ClickStart()
    {
        
        //MeshRenderer mr = GetComponent<MeshRenderer>();
        //mr.material.color = Color.gray;
    }

    public void ClickEnd()
    {
        
    }

    public void Click()
    {
        
    }
}
