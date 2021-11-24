using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public PlayerData data;
    public InputField jsonExample;
    public Text erase;
    private string file = "PlayerData.txt";

    void Start()
    {
        //Finds the input field and input field placeholder
        jsonExample = GameObject.Find("JSONoutput").GetComponent<InputField>();
        erase = GameObject.Find("jsonPlace").GetComponent<Text>();

    }


    public void SaveData()
    {
        //Writes the user data to the save file
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }

    public void LoadData()
    {
        //Reads the user data from the file
        data = new PlayerData();
        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data);

    }

    private void WriteToFile(string fileName, string json)
    {
        //Finds file path and writes out the data given in the json string
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFile(string fileName)
    {
        //Finds file path and reads in the data into the json string
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            //Displays warning of missing file
            Debug.LogWarning("File not found");
            return "";
        }
    }

    private string GetFilePath(string fileName)
    {
        //returns the file path
        return Application.persistentDataPath + "/" + fileName;
    }

    public void displayJSON()
    {
        //reads the json file into a string, erases the placeholder text, and sets the input field to the json string
        string json = ReadFromFile(file);
        erase.text = "";
        jsonExample.text = json;
    }

}

