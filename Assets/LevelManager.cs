using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance; // Singleton instance

    public List<AudioClip> levelBackgroundMusic; // List of background music for each level
    private int currentLevel = 0; // Current level

    private AudioSource bgmAudioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Make the GameManager persistent across scenes
        }
        else
        {
            Destroy(gameObject);
        }

        bgmAudioSource = GetComponent<AudioSource>();
    }

    public void ChangeLevel(int newLevel)
    {
        if (newLevel >= 0 && newLevel < levelBackgroundMusic.Count)
        {
            currentLevel = newLevel;
            bgmAudioSource.clip = levelBackgroundMusic[currentLevel];
            bgmAudioSource.Play();
        }
    }
}