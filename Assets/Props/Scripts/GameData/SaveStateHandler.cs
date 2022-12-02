using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class SaveStateHandler
{
    private readonly string path = "MainGameSaveState.json";
    public void SaveDataToJson(GameData gameData)
    {
        string json = JsonUtility.ToJson(gameData);
        File.WriteAllText(path, json);
    }

    public void LoadDataFromJson()
    {
        string content = File.ReadAllText(path);
        JsonUtility.FromJsonOverwrite(content, MainGameManager.Instance.gameData);
    }
    
}
