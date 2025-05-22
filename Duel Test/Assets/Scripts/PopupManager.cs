using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPrefab; 

    public void ShowPopup(string artworkPath, System.Action showAttackPosition, System.Action showDefensePosition)
    {
        // Popup instanziieren
        GameObject popup = Instantiate(popupPrefab, transform);

        // Button-Funktionen verbinden
        Button[] buttons = popup.GetComponentsInChildren<Button>();

        Image buttonOneImage = buttons[0].GetComponentInChildren<Image>();

        Image buttonTwoImage = buttons[1].GetComponentInChildren<Image>();

        buttonOneImage.sprite = Resources.Load<Sprite>(artworkPath);

        buttonTwoImage.sprite = Resources.Load<Sprite>(artworkPath);
        
        buttons[0].onClick.AddListener(() => { showAttackPosition?.Invoke(); Destroy(popup); });
        if (buttons.Length > 1 && showDefensePosition != null)
            buttons[1].onClick.AddListener(() => { showDefensePosition?.Invoke(); Destroy(popup); });
    }

    public void ShowCardPositionPopup(string artworkPath, Action<CardStates> onSelected)
    {
        // Popup instanziieren
        GameObject popup = Instantiate(popupPrefab, transform);

        // Button-Funktionen verbinden
        Button[] buttons = popup.GetComponentsInChildren<Button>();

        Image buttonOneImage = buttons[0].GetComponentInChildren<Image>();

        Image buttonTwoImage = buttons[1].GetComponentInChildren<Image>();

        RectTransform buttonTwoTransform = buttons[1].GetComponentInChildren<RectTransform>();

        buttonOneImage.sprite = Resources.Load<Sprite>(artworkPath);

        buttonTwoImage.sprite = Resources.Load<Sprite>(artworkPath);
        
        buttonTwoTransform.rotation = Quaternion.Euler(0, 0, 90);

        buttons[0].onClick.AddListener(() => {

                onSelected?.Invoke(CardStates.Attack);
                Destroy(popup);
            });

        buttons[1].onClick.AddListener(() =>{
                onSelected?.Invoke(CardStates.Defense);
                Destroy(popup);
        });

    }

    public void ShowFaceUpOrDownPopup(string artworkPath, Action<CardStates> onSelected)
    {
        // Popup instanziieren
        GameObject popup = Instantiate(popupPrefab, transform);

        // Button-Funktionen verbinden
        Button[] buttons = popup.GetComponentsInChildren<Button>();

        Image buttonOneImage = buttons[0].GetComponentInChildren<Image>();

        Image buttonTwoImage = buttons[1].GetComponentInChildren<Image>();

        buttonOneImage.sprite = Resources.Load<Sprite>(artworkPath);

        buttonTwoImage.sprite = Resources.Load<Sprite>("Sprites/Cardback");
        


        buttons[0].onClick.AddListener(() => {
                onSelected?.Invoke(CardStates.FaceUp);
                Destroy(popup);
            });

        buttons[1].onClick.AddListener(() =>{
                onSelected?.Invoke(CardStates.FaceDown);
                Destroy(popup);
        });

    }
}
