using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text cardText;
    public Text cost;
    public Text rarity;
    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        cardText.text= card.cardText;
        cost.text= card.cost.ToString();
        rarity.text= card.rarity;
        artworkImage.sprite= card.sprite;
    }

}
