using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggButton : MonoBehaviour
{
    
    public GameObject spaceShip;
    public GameObject engineFire;
    public GameObject explosion;

    public bool isExploding = false;
    
    public void HoverStart()
    {
        if (!isExploding)
        {       
            engineFire.SetActive(true);
        }
        //transform.localScale = Vector3.one * 100.1f;

    }

    public void HoverEnd()
    {
        if (!isExploding)
        {       
            engineFire.SetActive(false);
            
        }
        //transform.localScale = Vector3.one;
    }

    public void ClickStart()
    {

    }

    public void ClickEnd()
    {
        
    }

    public void Click()
    {

        StartCoroutine(WaitForExplosion());


        //yield return new WaitForSeconds(2.0f);
        //MeshRenderer mr = GetComponent<MeshRenderer>();
        //mr.material.color = Color.gray;
    }

    IEnumerator WaitForExplosion()
    {
        MeshRenderer spaceshipRenderer;
        Collider spaceshipCollider;
        isExploding = true;
        engineFire.SetActive(false);
        spaceshipRenderer = GetComponent<MeshRenderer>();
        spaceshipRenderer.enabled = false;
        spaceshipCollider = GetComponent<Collider>();
        spaceshipCollider.enabled = false;
        
        explosion.SetActive(true);
        
        yield return new WaitForSeconds(4f);
        spaceshipRenderer.enabled = true;
        explosion.SetActive(false);
        isExploding = false;
        spaceshipCollider.enabled = true;
    }
}
