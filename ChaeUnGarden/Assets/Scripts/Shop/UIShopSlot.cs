using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShopSlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text priceText;
    [SerializeField] private Image buttonImage;

    private Color[] buttonColor = { Color.red, Color.white };

    public void SetUIShopSlot(Item item)
    {
        icon.sprite = item.icon;
        nameText.text = item.Name;
        priceText.text = item.Price.ToString();
    }
    public void SetButtonColor(int isPossible)
    {
        buttonImage.color = buttonColor[isPossible];
    }
}
