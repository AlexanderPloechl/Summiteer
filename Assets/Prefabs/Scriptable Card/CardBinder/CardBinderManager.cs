using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBinderManager : MonoBehaviour
{

    public GameObject[] cardDisplays= new GameObject[3];
    public Card [] cards= {};

    // Update is called once per frame
    void Start()
    {
        foreach(GameObject o in cardDisplays){
            o.SetActive(false);
        }
        rearrangeCards();
    }

    void rearrangeCards(){
        if(cards.Length>0 && cards.Length<4){
            int i=0;
            for(; i<cards.Length; i++){
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
        if(cards.Length==1){
            cardDisplays[0].transform.localPosition= new Vector3(0,0,0);
        }
        if(cards.Length==2){
            cardDisplays[0].transform.localPosition= new Vector3(-200,0,0);
            cardDisplays[1].transform.localPosition= new Vector3(200,0,0);
        }
        if(cards.Length==3){
            cardDisplays[0].transform.localPosition= new Vector3(-330,0,0);
            cardDisplays[1].transform.localPosition= new Vector3(0,0,0);
            cardDisplays[2].transform.localPosition= new Vector3(330,0,0);
        }
    }
}
