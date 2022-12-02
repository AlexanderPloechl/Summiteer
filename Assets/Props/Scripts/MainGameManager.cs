using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class MainGameManager : MonoBehaviour
{
    private static MainGameManager instance;
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;
    private SaveStateHandler saveStateHandler;
    public GameData gameData;


    public static MainGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MainGameManager();
                instance.gameData = new GameData();
                instance.saveStateHandler = new SaveStateHandler();
            }

            return instance;
        }
    }

    //private void Awake()
    //{
    //    //Instance = this;
    //    Instance.gameData = new GameData();
    //}
    // Start is called before the first frame update
    void Start()
    {
        UpdateGameState(GameState.MainGame); 
    }

    // Update is called once per frame
    public void UpdateGameState(GameState newState)
    {
        gameState = newState;
        switch (newState)
        {
            case GameState.MainGame:
                saveStateHandler.LoadDataFromJson();
                SwitchToMainGame();
                break;
            case GameState.MiniGame:
                saveStateHandler.SaveDataToJson(instance.gameData);
                SwitchToMiniGame();
                break;
            //case GameState.CharacterSelection:
            //    break;
            //case GameState.Dice:
            //    break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        OnGameStateChanged?.Invoke(newState);
    }


    private void SwitchToMiniGame() 
    {
        int sceneNumber = Random.Range(1, SceneManager.sceneCountInBuildSettings);
        SceneManager.LoadScene(sceneNumber);
        //SceneManager.LoadScene(2);
    }
    private void SwitchToMainGame() 
    {
        Debug.Log("test (we back?)");
        SceneManager.LoadScene(0);
    }

}
