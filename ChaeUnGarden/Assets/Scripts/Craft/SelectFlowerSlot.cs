using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFlowerSlot : MonoBehaviour
{
    [SerializeField] private Flower flower;
    [SerializeField] private CraftManager craftManager;

    public void SelectFlower()
    {
        craftManager.SetFlower(flower);
    }
}
