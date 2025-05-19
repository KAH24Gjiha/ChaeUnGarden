using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlot : MonoBehaviour
{
    [SerializeField] private Item item;
    [SerializeField] private UIShopSlot uiSlot;

    private GameData data;
    void Start()
    {
        data = DataManager.Instance.gameData;
        uiSlot = GetComponent<UIShopSlot>();

        uiSlot.SetUIShopSlot(item);
        isBuy();
    }

    public void BuyItem()
    {
        if (isBuy())
        {
            data.money -= item.Price;

            item.Amount++;
            item.isLock = false;

            if (item.itemType == ItemType.furniture)
            {
                //배치모드
            }
        }
    }
    public bool isBuy()
    {
        if (data.money >= item.Price && !item.isLock)
        {
            uiSlot.SetButtonColor(1);
            return true;
        }
        else
        {
            uiSlot.SetButtonColor(0);
            return false;
        }
    }
}
