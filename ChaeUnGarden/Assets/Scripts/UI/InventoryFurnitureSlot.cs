using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryFurnitureSlot : MonoBehaviour
{
    [SerializeField] private InventorySlot slot;
    [SerializeField] private PlaceManager placeManager;
    [SerializeField] private GameObject useButton;
    Flower newf;

    public void SetUIBoxFurniture()
    {
        if(slot.item is Furniture)
        {
            useButton.SetActive(true);
            placeManager.furniture = (Furniture)slot.item;
        }
        
    }
}
