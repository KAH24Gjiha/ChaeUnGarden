using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICrafting : MonoBehaviour
{
    [SerializeField] private CraftManager craftManager;

    [SerializeField] private GameObject craftWindow;
    [SerializeField] private GameObject[] stepSlot;
    [SerializeField] private GameObject[] stepButton;
    [SerializeField] private GameObject decoObject;


    void Start()
    {
        craftManager = this.GetComponent<CraftManager>();
    }

    public void NextStep()
    {
        stepSlot[craftManager.stepIndex].SetActive(false);
        stepButton[craftManager.stepIndex].SetActive(false);

        craftManager.stepIndex++;
        decoObject.SetActive(true);

        stepSlot[craftManager.stepIndex].SetActive(true);
        stepButton[craftManager.stepIndex].SetActive(true);
    }
    public void CloseCraftUI()
    {
        craftWindow.SetActive(false);
    }
}
