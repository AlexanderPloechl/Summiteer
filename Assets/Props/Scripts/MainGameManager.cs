using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class MainGameManager : MonoBehaviour
{
    //private static MainGameManager instance;
    public static MainGameManager Instance;
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;
    //private static SaveStateHandler saveStateHandler = new SaveStateHandler();
    //public GameData gameData;


    //public static MainGameManager Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = GameObject.Find("GameManager").GetComponent<MainGameManager>();
    //            Debug.Log("instance was null");
    //        }

    //        return instance;
    //    }
    //}

    private void Awake()
    {
        Instance = this;
    }
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
                //saveStateHandler.LoadDataFromJson();
                Debug.Log("maingame");
                SwitchToMainGame();
                break;
            case GameState.MiniGame:
                //saveStateHandler.SaveDataToJson(instance.gameData);
                //saveStateHandler.SaveDataToJson(Instance.gameData);
                Debug.Log("minigame");
                SwitchToMiniGame();
                break;
            //case GameState.CharacterSelection:
            //    break;
            //case GameState.Dice:
            //    break;
            case GameState.GameEnded:
                SaveStateHandler.ResetSaveState();
                break;
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
        Debug.Log("switch to main game");
        //SceneManager.LoadScene(0);
        if(SceneManager.GetActiveScene().name != SceneManager.GetSceneByBuildIndex(0).name)
        {
            SceneManager.LoadScene(0);
        }
    }

}
