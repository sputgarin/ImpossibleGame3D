using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class BGMController : MonoBehaviour
    {
        public AudioSource bgmAudioSource;
        public List<AudioClip> levelBackgroundMusic;
        public int currentLevel; // The current level

        private void Awake()
        {
            bgmAudioSource = GetComponent<AudioSource>();
        }

        public void PlayBGM()
        {
            
            if (currentLevel >= 0 && currentLevel < levelBackgroundMusic.Count)
            {
                
                bgmAudioSource.clip = levelBackgroundMusic[currentLevel];
                bgmAudioSource.Play();
            }

        }
        
        public void ChangeLevel(int newLevel)
        {
            
            currentLevel = newLevel - 3;
            if (newLevel >= 0 && newLevel < levelBackgroundMusic.Count)
            {
                Debug.Log("Current level is:" + currentLevel);
                bgmAudioSource.clip = levelBackgroundMusic[currentLevel];
                bgmAudioSource.Play();
            }

        }
        

        // Update is called once per frame
    }

