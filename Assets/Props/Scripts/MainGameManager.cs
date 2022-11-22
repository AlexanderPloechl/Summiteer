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

    //private MainGameMananger()
    //{
    //    // initialize your game manager here. Do not reference to GameObjects here (i.e. GameObject.Find etc.)
    //    // because the game manager will be created before the objects
        
    //}

    public static MainGameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MainGameManager();
            }

            return instance;
        }
    }

    //private void Awake()
    //{
    //    Instance = this;
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
                SwitchScene();
                break;
            case GameState.MiniGame:
                SwitchScene();
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

    private void SwitchScene()
    {
        if (gameState.Equals(GameState.MiniGame))
        {
            int sceneNumber = Random.Range(1, SceneManager.sceneCountInBuildSettings);
            SceneManager.LoadScene(sceneNumber);
        }
        else if (gameState.Equals(GameState.MainGame))
        {
            Debug.Log("test (we back?)");
            SceneManager.LoadScene(0);
        }
    }

}
