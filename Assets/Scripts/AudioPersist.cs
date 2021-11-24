using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPersist : MonoBehaviour
{
 
    void Awake()
    {

        //Finds the background music and persists it through scene changes
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if(backgroundMusic.Length > 1)
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

        //if scene is switched from menu to play game this discontinues the menu music
        GameObject[] backgroundMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (sceneName == "Scene_Play_Game")
        {
            Destroy(this.gameObject);
        }
    }
}
