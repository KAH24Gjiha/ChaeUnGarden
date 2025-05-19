using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    public Furniture furniture;

    [SerializeField] private Placement placement;

    void Start()
    {
        placement = this.GetComponent<Placement>();
    }

    public void StartPlacement()
    {
        placement.StartSetPlace(furniture.furnitureObj);
    }
}
