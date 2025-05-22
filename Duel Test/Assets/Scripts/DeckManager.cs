using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public string jsonFileName = "Yugi_Deck";

    private CardList deck; 
    void Start()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "cards", jsonFileName + ".json");
        string json = File.ReadAllText(path);
        deck = JsonConvert.DeserializeObject<CardList>(json);
        Debug.Log("Deck geladen!");
    }

    public CardData DrawCard()
    {
        Debug.Log("Karte wird gelesen!");
        if (deck != null)
        {
            int index = Random.Range(0, deck.cards.Count);
            CardData card = deck.cards[index];
            deck.cards.RemoveAt(index); 
            
            return card;
        }
        
        return null;
    }

}
