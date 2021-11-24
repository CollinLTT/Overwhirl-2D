using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;

    //user input variables
    public bool charGenerated;
    public string charName;
    public string pattern;
    public string difficulty;

    private void Awake()
    {
        //persists the data through various scenes
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }

    }


    public void setTrue()
    {
        //Upon hittin the button "save character" sets the following variables to the user inputs
        charName = GameObject.Find("UIobj").GetComponent<UI>().singletonName;

        pattern = GameObject.Find("UIobj").GetComponent<UI>().singletonPattern;

        difficulty = GameObject.Find("UIobj").GetComponent<UI>().singletonDifficulty;

        if (charName != null && pattern != null && difficulty != null)
        {
            charGenerated = true;
        }

    }
 
}


