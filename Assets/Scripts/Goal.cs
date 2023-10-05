
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider col)
    {
        
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(1);
    }
}