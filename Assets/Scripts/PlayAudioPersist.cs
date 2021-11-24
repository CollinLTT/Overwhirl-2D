using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAudioPersist : MonoBehaviour
{
    void Awake()
    {
        //Finds the background music and persists it through scene changes
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("PlayMusic");
        if (backgroundMusic.Length > 1)
        {
            //makes sure the background audio doesnt double itself
            Destroy(this.gameObject);
        }
        else
            DontDestroyOnLoad(this.gameObject);


    }

    void Update()
    {
        //checks for current scene
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        //if scene switches from play to main menu this discontinues the play scene background music
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("PlayMusic");
        if (sceneName == "Scene_Main_Menu")
        {
            Destroy(this.gameObject);
        }
    }
}

