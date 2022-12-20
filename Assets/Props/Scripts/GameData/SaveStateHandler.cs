using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class SaveStateHandler
{
    private readonly string path = "\\Assets\\Props\\Scripts\\GameData\\MainGameSaveState.json";
    public void SaveDataToJson(GameData gameData)
    {
        Debug.Log("Save");
        string json = JsonUtility.ToJson(gameData);
        Debug.Log("save"+json);
        Debug.Log(Directory.GetCurrentDirectory() + path);
        File.WriteAllText(Directory.GetCurrentDirectory() + path, json);
    }

    public void LoadDataFromJson()
    {
        Debug.Log("Load");
        string content = File.ReadAllText(Directory.GetCurrentDirectory() + path);
        Debug.Log("load"+content);
        Debug.Log(Directory.GetCurrentDirectory() + path);
        JsonUtility.FromJsonOverwrite(content, MainGameManager.Instance.gameData);
    }
    
}
