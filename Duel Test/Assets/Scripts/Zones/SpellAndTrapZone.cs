using UnityEngine.EventSystems;
public class SpellAndTrapZone : MonsterAndSpellBase
{
    public override void PlaceCard(PointerEventData eventData)
    {
        CardDragHandler cardHandler = eventData.pointerDrag.GetComponent<CardDragHandler>();

        cardManager = eventData.pointerDrag.GetComponent<CardManager>();

        CardData cardData = cardManager.GetCardData();

        if (cardHandler != null && (cardData.type == CardType.Spell || cardData.type == CardType.Trap))
        {            
            ShowFaceUporDownPopUp(cardData, () => {
                DropCardOnZone(cardHandler);
            });
            
        }
        
    }


}