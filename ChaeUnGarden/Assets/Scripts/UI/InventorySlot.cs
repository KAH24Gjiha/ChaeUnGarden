using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Item item;

    [SerializeField] private Image slotImage;
    [SerializeField] private TMP_Text amountText;
    //UI박스 설정


    public void UpdateSlot(Item item)
    {
        if (item != null)
        {
            this.item = item;

            slotImage.color = Color.white;
            //slotImage.sprite = item.icon;
            amountText.text = item.Amount.ToString();
        }
        else
        {
            slotImage.color = Color.clear;
        }
    }
    public void SetUIBox()
    {

    }
}
