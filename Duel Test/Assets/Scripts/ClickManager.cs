using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour, IPointerClickHandler
{
    public DeckManager deckManager;

    public HandManager handManager;
    //Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        CardData cardFromDeck = deckManager.DrawCard();
        handManager.SetCardToHand(cardFromDeck);
    }
}