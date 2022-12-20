using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int YellowPosition;
    public int RedPosition;
    public int BluePosition;
    public int WhitePosition;

    public bool isFirstRound;
    public int trophyPosition;

    public GameData()
    {
        this.YellowPosition = -1;
        this.BluePosition = -1;
        this.RedPosition = -1;
        this.WhitePosition = -1;
        this.isFirstRound = true;
        Debug.Log("GameData Constructor");
    }

}
