using UnityEngine.EventSystems;
public class MonsterZone : MonsterAndSpellBase
{
    public override void PlaceCard(PointerEventData eventData)
    {
        CardDragHandler cardHandler = eventData.pointerDrag.GetComponent<CardDragHandler>();

        cardManager = eventData.pointerDrag.GetComponent<CardManager>();
        
        CardData cardData = cardManager.GetCardData();

        if (cardHandler != null && cardData.type == CardType.Monster)
        {
            ShowATKorDEFPopUp(cardData, () =>
            {
                ShowFaceUporDownPopUp(cardData, () =>
                {
                    DropCardOnZone(cardHandler);
                });
            });
        }
    }
}