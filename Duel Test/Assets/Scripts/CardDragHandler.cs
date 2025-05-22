using UnityEngine;
using UnityEngine.EventSystems;

public class CardDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent = null;
    private bool droppedOnZone = false;

    public void OnBeginDrag(PointerEventData eventData)
    {

        droppedOnZone = false;
        originalParent = transform.parent;
        Transform canvasTransform = this.transform.root.GetComponentInChildren<Canvas>().transform;
        this.transform.SetParent(canvasTransform);
        
        GetComponent<CanvasGroup>().blocksRaycasts = false; 
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (!droppedOnZone)
        {   
            this.transform.SetParent(originalParent);
            this.transform.localPosition = Vector3.zero;
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true; 
    }

    public void MarkAsDropped()
    {
        droppedOnZone = true;
    }

}
