using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{   
    public ZoneType zoneType; 

    public void OnDrop(PointerEventData eventData)
    {
        CardDragHandler cardHandler = eventData.pointerDrag.GetComponent<CardDragHandler>();

        if (cardHandler != null)
        {
            if((zoneType == ZoneType.Monster || zoneType == ZoneType.Spell || zoneType == ZoneType.Field) && this.transform.childCount > 0)
            {
                return;
            }
            else{
                
                CardData card = GetCardData(eventData);
                
                
                cardHandler.MarkAsDropped(); 
                cardHandler.transform.SetParent(this.transform);
                cardHandler.transform.localPosition = Vector3.zero;
            }
        }
    }

    private CardData GetCardData(PointerEventData eventData ){

            CardManager display = eventData.pointerDrag.GetComponent<CardManager>();
            CardData data = display.GetCardData();

            return data;
    }
}


