using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManager : MonoBehaviour
{
    public Flower selectFlower;
    public int stepIndex;

    [SerializeField] CraftingBouquet crafting;
    void Start()
    {
        
    }

    public void SetFlower(Flower flower)
    {
        selectFlower = flower;
    }
}
