using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //All variables to be used in menu
    public DataManager dataManager;

    public string charName;
    public int charCoins;
    public string charDifficulty;
    public string charPattern;

    public string singletonName;
    public string singletonPattern;
    public string singletonDifficulty;


    // Start is called before the first frame update
    void Start()
    {
        //loads all the data from the text file
        dataManager.LoadData();

        //initializes inputs to file inputs
        charName = dataManager.data.CharacterName;

        charCoins = dataManager.data.Coins;

        charDifficulty = dataManager.data.Difficulty;

        charPattern = dataManager.data.Pattern;


    }

    public void Callback_Char_Name(string name)
    {
        //sets the Character name in the file to user input
        dataManager.data.CharacterName = name;
        singletonName = name;
    }

    public void Callback_Coins(string coins)
    {
        dataManager.data.Coins = int.Parse(coins);
    }

    //finds the user set difficulty (default difficulty is normal)
    public void Callback_Difficulty(int difficulty)
    {
        if (difficulty == 0)
        {
            dataManager.data.Difficulty = "Normal";
            singletonDifficulty = "Normal";
        }
        if (difficulty == 1)
        {
            dataManager.data.Difficulty = "Normal";
            singletonDifficulty = "Normal";
        }
        if (difficulty == 2)
        {
            dataManager.data.Difficulty = "Moderate";
            singletonDifficulty = "Moderate";
        }
        if (difficulty == 3)
        {
            dataManager.data.Difficulty = "Overwhirl";
            singletonDifficulty = "Overwhirl";
        }
      
    }

    //finds the user set pattern (default pattern is Yin Yang)
    public void Callback_Pattern(int pattern)
    {
        if (pattern == 0)
        {
            dataManager.data.Pattern = "Yin Yang";
            singletonPattern = "Yin Yang";
        }
        if (pattern == 1)
        {
            dataManager.data.Pattern = "Yin Yang";
            singletonPattern = "Yin Yang";
        }
        if (pattern == 2)
        {
            dataManager.data.Pattern = "Peppermint";
            singletonPattern = "Peppermint";
        }

    }

    public void Callback_Save()
    {
        //saves all the user input data into the file
        dataManager.SaveData();
    }


}
