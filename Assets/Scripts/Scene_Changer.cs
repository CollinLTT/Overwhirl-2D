using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public Button playButton;

    void Start()
    {

        //checks for the current scene name
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Scene_Main_Menu")
        {
            //checks for main menu scene to reduce requests for singleton data
            PlayButton_Interact();
        }

        if (sceneName == "Scene_Play_Game")
        {
            //checks for play game scene to run the customized user selected data
            Customize_Interact();
        }

    }

    public void Roll_Character_Scene()
    {
        SceneManager.LoadScene("Scene_Roll_Character");
    }

    public void Main_Menu_Scene()
    {
        SceneManager.LoadScene("Scene_Main_Menu");
    }

 public void Play_Game_Scene()
    {
        SceneManager.LoadScene("Scene_Play_Game");
    }

 public void Settings_Scene()
    {
        SceneManager.LoadScene("Scene_Settings");
    }

 public void About_Scene()
    {
        SceneManager.LoadScene("Scene_About");
    }

 public void PlayButton_Interact()
    {
        //Makes the play button usable if a character is generated with the "save character" button
        if (Singleton.instance.charGenerated == true && playButton.interactable == false)
        {
            playButton.interactable = true;
        }

    }

 public void Customize_Interact()
    {
        //Sets username to user selected name, if empty defaults to "user01"
        Text name;
        name = GetComponent<Text>();
        if(Singleton.instance.charName == "")
        {
            name.text = ": User01";
        }
        else
        {
            name.text = ": " + Singleton.instance.charName;
        }

        //checks for user selected difficulty and adjusts as such
        if (Singleton.instance.difficulty == "Moderate")
        {
            GameObject.Find("CharacterYin").GetComponent<CharControls>().MovementSpeed = 1000;

        }
        if (Singleton.instance.difficulty == "Overwhirl")
        {
            GameObject.Find("CharacterYin").GetComponent<CharControls>().MovementSpeed = 1300;

        }

    }
}
