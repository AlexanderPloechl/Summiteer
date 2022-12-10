using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Card")]
public class Card : ScriptableObject
{
    public string cardText;
    public int cost;
    public string rarity;
    public Sprite sprite;

}
