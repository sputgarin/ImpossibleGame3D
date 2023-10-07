using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuButtons : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void RestartLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

}
