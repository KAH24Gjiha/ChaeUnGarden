using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepingBouquet : MonoBehaviour
{
    [SerializeField] private List<Bouquet> bouquets = new List<Bouquet>();
    [SerializeField] private BouquetSlot[] slots;
    [SerializeField] private GameObject slotParent;

    private bool isTake;

    void Start()
    {
        slots = slotParent.GetComponentsInChildren<BouquetSlot>();
    }
    public void SetIsTake(bool take)
    {
        isTake = take;
    }
    public void AddBouquet(Bouquet bouquet)
    {
        bouquets.Add(bouquet);

        UpdateBouquets();
    }
    public void DeleteBouquet(int index)
    {
        bouquets.Remove(bouquets[index]);

        UpdateBouquets();
    }
    private void UpdateBouquets()
    {
        for (int index = 0; index < slots.Length && index < bouquets.Count; index++)
        {
            slots[index].UpdateSlot(bouquets[index]);
        }
    }

}
