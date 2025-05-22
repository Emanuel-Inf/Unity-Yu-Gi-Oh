using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IZoneBase: IDropHandler
{
    void OnDrop(PointerEventData eventData);
}
