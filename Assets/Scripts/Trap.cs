using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.SendMessage("Death");
            yield return new WaitForSeconds(2);
            collision.gameObject.SendMessage("Respawn");
            //int currentScene = SceneManager.GetActiveScene().buildIndex;
           // SceneManager.LoadScene(currentScene);
        }

    }
}