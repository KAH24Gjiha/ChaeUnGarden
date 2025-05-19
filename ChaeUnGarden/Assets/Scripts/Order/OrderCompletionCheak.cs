using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderCompletionCheak : MonoBehaviour
{
    public Order order;

    [SerializeField] private OrderManager orderManager;
    [SerializeField] private UIOrderInfo uiOrderInfo;
    [SerializeField] private GameObject orderTakeWindow;

    public void MeetOrderer(Order receivedOrder)
    {
        order = receivedOrder;

        uiOrderInfo.SetUIOrder(order);
        orderTakeWindow.SetActive(true);
    }
    public void AcceptanceOrder()
    {
        //예약이면 보관함
        //방문이면 제작 탭
    }
    public void RejectOrder()
    {
        uiOrderInfo.FailReceipt();
    }

    public void CheakCompletion(Bouquet bouquet)
    {
        int price = bouquet.price;
        int bonus = 0;

        if(order.requestType == bouquet.bouquetType)
        {
            bonus++;
        }
        if(order.requestSize == bouquet.sizeType)
        {
            bonus++;
        }
        if(order.colorType == bouquet.colorType)
        {
            bonus++;
        }
        if(order.flowerType == bouquet.flowerType)
        {
            bonus++;
        }
        foreach(var flower in order.signatureFlower)
        {
            if (flower == bouquet.signatureFlower)
            {
                bonus++;
            }
        }

        price += (bouquet.price / 10) * bonus;

        orderManager.FinishReceipt(price);
    }
}
