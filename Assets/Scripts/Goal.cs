
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider col)
    {
        
        yield return new WaitForSeconds(0.5f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        currentScene++;
        int nextScene = currentScene;
        SceneManager.LoadScene(nextScene);
    }
}