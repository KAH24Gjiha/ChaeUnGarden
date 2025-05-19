using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BouquetSlot : MonoBehaviour
{
    public Bouquet bouquet;

    [SerializeField] private FlowerSlot[] flowerSlot;
    [SerializeField] private Transform[] bouquetType;
    [SerializeField] private Image decoFront;
    [SerializeField] private Image decoBack;

    private Transform bouquetSlot;

    void Start()
    {
        flowerSlot = GetComponentsInChildren<FlowerSlot>();
    }

    public void UpdateSlot(Bouquet bouquet)
    {
        InitSlot();
        this.bouquet = bouquet;

        bouquetSlot = bouquetType[(int)bouquet.bouquetType];
        flowerSlot = bouquetSlot.GetComponentsInChildren<FlowerSlot>();
        decoBack = bouquetSlot.GetChild(0).GetComponent<Image>();
        decoFront = bouquetSlot.GetChild(25).GetComponent<Image>();

        for (int i = 0; i < flowerSlot.Length; i++)
        {
            flowerSlot[i].UpdateSlot(bouquet.flowers[i]);
        }

        decoBack.sprite = bouquet.decoBackSprite;
        decoFront.sprite = bouquet.decoFrontSprite;
    }
    private void InitSlot()
    {
        foreach (var Obj in bouquetType)
        {
            Obj.gameObject.SetActive(false);
        }
    }
}
