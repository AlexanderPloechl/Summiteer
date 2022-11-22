using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class DataPersistenceManager : MonoBehaviour
{
    private GameData gameData;
    public static DataPersistenceManager instance { get; private set; }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("There should only be one DataPersistenceManager, but found more");
        }
        instance = this;
    }

    private void Start()
    {
        LoadMainGameData();
    }

    public void NewMainGameData() 
    {
        this.gameData = new GameData();
    }
    public GameData LoadMainGameData() 
    { 
        //if keine daten zu laden -> newmaingamedata
        if(gameData == null)
        {
            gameData = new GameData();
        }
        string path = "C:/Users/alexc/Desktop/Technikum 2.0/SummiteerNewRepo/Sumitteer/Assets/Props/Scripts/GameData";
        if (File.Exists(path))
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                JsonUtility.FromJsonOverwrite(json, gameData);
            }
        }
        return gameData;
    }
    public void SaveMainGameData(GameData gameData) 
    {
        string path = "C:/Users/alexc/Desktop/Technikum 2.0/SummiteerNewRepo/Sumitteer/Assets/Props/Scripts/GameData";
        FileStream fileStream = new FileStream(path, FileMode.Create);
        string json = JsonUtility.ToJson(gameData);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }
    public void DeleteMainGameData() { }
}
