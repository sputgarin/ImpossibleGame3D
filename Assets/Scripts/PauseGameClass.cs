using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameClass : MonoBehaviour
{
    public bool paused;
    public GameObject inGameMenu;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseGame();
        }
    }
    
    public void PauseGame()
    {
        
        paused = !paused;
        if (paused == true)
        {
            inGameMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            inGameMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
    
}
