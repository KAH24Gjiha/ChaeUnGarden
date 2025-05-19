using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDecoSlot : MonoBehaviour
{
    [SerializeField] private Decorate decorate;
    [SerializeField] private CraftingBouquet craftingBouquet;

    [SerializeField] private DecorateSlot decoFront;
    [SerializeField] private DecorateSlot decoBack;

    public void SelectDecorate()
    {
        craftingBouquet.SelectDecorate(decorate);
        craftingBouquet.SelectType(decorate.bouquetType);

        decoFront.UpdateSlot(decorate);
        decoBack.UpdateSlot(decorate);
    }
}
