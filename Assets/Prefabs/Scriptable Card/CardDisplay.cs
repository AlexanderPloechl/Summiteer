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
    public void setCard(Card newCard)
    {
        card= newCard;
        updateCard();
        
    }

    void Start(){
        if(card!=null){
            updateCard();
        }
    }
    void updateCard(){
        cardText.text= card.cardText;
        cost.text= card.cost.ToString();
        rarity.text= card.rarity;
        artworkImage.sprite= card.sprite;
    }

}
