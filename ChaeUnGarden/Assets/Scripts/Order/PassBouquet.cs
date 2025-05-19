using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBouquet : MonoBehaviour
{
    [SerializeField] private OrderCompletionCheak completionCheak;
    [SerializeField] private KeepingBouquet keeper;
    [SerializeField] private BouquetSlot bouquetSlot;

    [SerializeField] private int slotIndex;

    public void PassCheak()
    {
        completionCheak.CheakCompletion(bouquetSlot.bouquet);
        keeper.DeleteBouquet(slotIndex);
    }
}
