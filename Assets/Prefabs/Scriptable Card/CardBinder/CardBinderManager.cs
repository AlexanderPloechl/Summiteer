using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBinderManager : MonoBehaviour
{

    public GameObject[] cardDisplays= new GameObject[3];
    public List<Card> cards= new List<Card>();

    // Update is called once per frame
    void Start()
    {
        foreach(GameObject o in cardDisplays){
            o.SetActive(false);
        }
        rearrangeCards();
    }

    public void addCard(Card card){
        if(cards.Count<3){
            cards.Add(card);
        }
    }

    public void removeCard(Card card){
        
        
    }
    public void removeCardAt(int i){
        if(cards.Count>0){
            cards.RemoveAt(i);
        }
    }

    void rearrangeCards(){
        if(cards.Count>0 && cards.Count<4){
            int i=0;
            for(; i<cards.Count; i++){
                cardDisplays[i].GetComponent<CardDisplay>().setCard(cards[i]);
                cardDisplays[i].SetActive(true);
            }
            for(; i<cardDisplays.Length; i++){
                cardDisplays[i].SetActive(false);
            }

            setCardPositions();

            
        }
    }

    void setCardPositions(){
        if(cards.Count==1){
            cardDisplays[0].transform.localPosition= new Vector3(0,0,0);
        }
        if(cards.Count==2){
            cardDisplays[0].transform.localPosition= new Vector3(-200,0,0);
            cardDisplays[1].transform.localPosition= new Vector3(200,0,0);
        }
        if(cards.Count==3){
            cardDisplays[0].transform.localPosition= new Vector3(-330,0,0);
            cardDisplays[1].transform.localPosition= new Vector3(0,0,0);
            cardDisplays[2].transform.localPosition= new Vector3(330,0,0);
        }
    }
}
