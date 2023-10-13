using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistantManager : MonoBehaviour
{
     
    private static bool persistantGameObjectExists = false;
    void Awake()
    {
        GameObject persistantManager = this.gameObject;
        
        if (!persistantGameObjectExists)
        {
            DontDestroyOnLoad(persistantManager);
            persistantGameObjectExists = true;
            
        }
        else
        {
            
            Destroy(this.gameObject);
        }
    }
}
