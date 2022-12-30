using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using UnityEngine.Playables;

public static class SaveStateHandler
{
    private static readonly string path = "\\Assets\\Props\\Scripts\\GameData\\MainGameSaveState.json";
    public static void SaveDataToJson(GameData gameData)
    {
        //Debug.Log("Save");
        string json = JsonUtility.ToJson(gameData);
        Debug.Log("save"+json);
        //Debug.Log(Directory.GetCurrentDirectory() + path);
        File.WriteAllText(Directory.GetCurrentDirectory() + path, json);
    }

    public static GameData LoadDataFromJson()
    {
        //Debug.Log("Load");
        string content = File.ReadAllText(Directory.GetCurrentDirectory() + path);
        Debug.Log("load"+content);
        //Debug.Log(Directory.GetCurrentDirectory() + path);
        GameData data = new GameData();
        JsonUtility.FromJsonOverwrite(content, data);
        return data;
    }

    public static void ResetSaveState()
    {
        //Debug.Log("Reset");
        string json = JsonUtility.ToJson(new GameData());
        Debug.Log("reset to" + json);
        //Debug.Log(Directory.GetCurrentDirectory() + path);
        File.WriteAllText(Directory.GetCurrentDirectory() + path, json);
    }
    
}
