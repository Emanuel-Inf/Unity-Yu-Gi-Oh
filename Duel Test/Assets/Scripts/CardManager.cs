using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public Image cardArtwork;
    private CardData cardData;
    private CardStates cardPosition;

    /*public void SetCard(CardData data, Sprite artwork)
    {
        cardData = data;
        cardArtwork.sprite = artwork;
    }*/

    public CardData GetCardData()
    {
        return cardData;
    }

    public void SetCardData(CardData data){
        cardData = data;
    }
    public void ShowFaceUpSprite(){

        cardArtwork.sprite = Resources.Load<Sprite>(cardData.artworkPath);
    }

    public void ShowFaceDownSprite(){

        cardArtwork.sprite = Resources.Load<Sprite>("Sprites/Cardback");
    }

    public void SetAttackPosition(){
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }   
    public void SetDefensePosition(){
        transform.localRotation = Quaternion.Euler(0, 0, 90);
    }
}
