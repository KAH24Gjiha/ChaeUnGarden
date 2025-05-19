using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOrderTake : MonoBehaviour
{
    [SerializeField] private OrderCompletionCheak completionCheak;
    [SerializeField] private NPCMovement movement;
    [SerializeField] private Order order;

   void Start()
    {

    }
    public void SetOrder(Order newOrder)
    {
        order = newOrder;

        this.gameObject.SetActive(true);
        movement.GoCounter();
    }
    private void OnMouseDown()
    {
        completionCheak.MeetOrderer(order);
    }
}
