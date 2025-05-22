using System.Collections.Generic;
using UnityEngine;
public class HandManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform spawnParent;
    private List<CardData> cards; 
    public DeckManager deckManager;
    void Start()
    {
        cards = new List<CardData>();
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {   
            
            CardData card = deckManager.getCard();
            cards.Add(card);
            Debug.Log(card.cardName);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            setCard();
        }
    }

    void showCardsInHand(){

        foreach (CardData element in cards){
            print(element.cardName);
        }
    }

    void SetCardToHand()
    {
        CardData cardToset = cards[0];
        cards.RemoveAt(0);
        Sprite artwork = Resources.Load<Sprite>(cardToset.artworkPath);

        if (artwork == null)
        {
            Debug.LogError("❌ Sprite nicht gefunden! Pfad: " + cardToset.artworkPath);
        }
        else
        {
            Debug.Log("✅ Sprite geladen: " + artwork.name);
        }

        GameObject card = Instantiate(cardPrefab, spawnParent);
        CardDisplay display = card.GetComponent<CardDisplay>();
        display.SetCard(cardToset, artwork);
        Debug.Log("Karte wurde in die Hand genommen:" + cardToset.cardName);
    }

    public void SetCardInHand(CardData card){
            cards.Add(card);
            SetCardToHand(card);
    }*/

    public void SetCardToHand(CardData card){
        cards.Add(card);

        GameObject cardInstance = Instantiate(cardPrefab, spawnParent);
        
        CardManager display = cardInstance.GetComponent<CardManager>();
        display.SetCardData(card);

        display.ShowFaceUpSprite();
    }
}
