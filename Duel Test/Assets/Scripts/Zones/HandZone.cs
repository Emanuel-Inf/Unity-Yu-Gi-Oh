using UnityEngine;
using UnityEngine.EventSystems;

public class HandZone : MonoBehaviour, IZoneBase
{
    public void OnDrop(PointerEventData eventData)
    {
        CardDragHandler cardHandler = eventData.pointerDrag.GetComponent<CardDragHandler>();
        CardManager cardManager = eventData.pointerDrag.GetComponent<CardManager>();

        if (cardHandler != null)
        {
            cardManager.ShowFaceUpSprite();
            cardManager.SetAttackPosition();
            
            cardHandler.MarkAsDropped();
            cardHandler.transform.SetParent(this.transform);
            cardHandler.transform.localPosition = Vector3.zero;

        }
    }
}