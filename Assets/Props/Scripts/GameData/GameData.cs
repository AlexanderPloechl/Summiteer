using JetBrains.Annotations;
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

    public bool YellowIsPlaying;
    public bool RedIsPlaying;
    public bool BlueIsPlaying;
    public bool WhiteIsPlaying;

    public bool isFirstRound;
    public int trophyPosition;
    public int numberOfRounds;

    public List<string> TurnSequence;

    public GameData()
    {
        this.YellowPosition = -1;
        this.BluePosition = -1;
        this.RedPosition = -1;
        this.WhitePosition = -1;

        this.YellowIsPlaying = false;
        this.RedIsPlaying = false;
        this.BlueIsPlaying = false;
        this.WhiteIsPlaying = false;

        this.trophyPosition = -1;
        this.numberOfRounds = 0;
        this.isFirstRound = true;

        this.TurnSequence = new List<string>();

        //Debug.Log("GameData Constructor");
    }

}
