
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    public GameObject bgmsomething;
    private void Awake()
    {
        // bgmsomething = GameObject.Find("BGM");
    }

    
    IEnumerator OnTriggerEnter(Collider collision)
    {
        yield return new WaitForSeconds(0.5f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        currentScene++;
        int nextScene = currentScene;
        Debug.Log("Next scene is:" +nextScene);
        //change music
        // bgmsomething.GetComponent<BGMController>().ChangeLevel(nextScene);
        SceneManager.LoadScene(nextScene);
    }
}

