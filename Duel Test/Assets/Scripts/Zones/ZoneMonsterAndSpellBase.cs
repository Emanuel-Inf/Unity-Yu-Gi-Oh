using UnityEngine;
using UnityEngine.EventSystems;
using System;
public abstract class MonsterAndSpellBase : MonoBehaviour, IZoneBase
{

    public PopupManager popupManager;
    protected CardManager cardManager;
    public void OnDrop(PointerEventData eventData)
    {

        if (this.transform.childCount == 0)
        {
            PlaceCard(eventData);
        }
    }

    public abstract void PlaceCard(PointerEventData eventData);
    
    
    protected void ShowFaceUporDownPopUp(CardData cardData, Action onComplete)
    {

        popupManager.ShowFaceUpOrDownPopup(cardData.artworkPath, selectedPosition =>
        {

            if (selectedPosition == CardStates.FaceUp)
            {
                cardManager.ShowFaceUpSprite();
            }
            else
            {
                cardManager.ShowFaceDownSprite();
            }
            onComplete?.Invoke();
        });
    }

    protected void ShowATKorDEFPopUp(CardData cardData, Action onComplete)
    {
        popupManager.ShowCardPositionPopup(cardData.artworkPath, selectedPosition =>
        {

            if (selectedPosition == CardStates.Defense)
            {
                cardManager.SetDefensePosition();
            }
            else
            {
                cardManager.SetAttackPosition();
            }
            onComplete?.Invoke();
        });
    }

    protected void DropCardOnZone(CardDragHandler cardHandler){
            cardHandler.MarkAsDropped();
            cardHandler.transform.SetParent(this.transform);
            cardHandler.transform.localPosition = Vector3.zero;
    }

}