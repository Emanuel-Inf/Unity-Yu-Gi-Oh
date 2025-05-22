using System.Collections.Generic;
using System.IO;
using UnityEngine;

/*public class CardLoader : MonoBehaviour
{
    public string jsonFileName = "Yugi_Deck";
    public GameObject cardPrefab;
    public Transform spawnParent;
    private int index = 0; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // z. B. Leertaste
        {
            LoadCards();
        }
    }

    public void LoadCards(){
        string path = Path.Combine(Application.streamingAssetsPath, "cards", jsonFileName + ".json");
        string json = File.ReadAllText(path);
        CardList data = JsonUtility.FromJson<CardList>(json);

        Sprite artwork = Resources.Load<Sprite>(data.cards[index].artworkPath);
        if (artwork == null)
        {
            Debug.LogError("❌ Sprite nicht gefunden! Pfad: " + data.cards[index].artworkPath);
        }
        else
        {
            Debug.Log("✅ Sprite geladen: " + artwork.name);
        }

        GameObject card = Instantiate(cardPrefab, spawnParent);
        CardDisplay display = card.GetComponent<CardDisplay>();
        display.SetCard(data.cards[index], artwork);
        index ++;
    }
}*/
