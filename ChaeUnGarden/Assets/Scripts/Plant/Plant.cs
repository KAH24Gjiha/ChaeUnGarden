using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plant : MonoBehaviour
{
    [SerializeField] private Flower flower;
    [SerializeField] private Sapling sapling;

    [SerializeField] private GameObject infoWindow;
    [SerializeField] private SpriteRenderer plantSprite;

    [SerializeField] private UIPlantInfo uiPlant;

    private int currentTime;
    private bool isCompleteGrow = false;

    void Start()
    {
        currentTime = sapling.growTime;
        //StartCoroutine(GrowPlant());
    }
    private void OnMouseDown()
    {
        Debug.Log("눌림");
        if (isCompleteGrow)
        {
            CompleteGrow();
        }
        else
        {
            uiPlant.SetPosition(transform);
        }
    }
    public void SetUIComponenet(UIPlantInfo ui)
    {
        uiPlant = ui;
    }
    private void CompleteGrow()
    {
        //flower.Amount += flower.levelDetail[flower.flowerLevel].getAmount;
        StartCoroutine(GrowPlant());
    }
    private IEnumerator GrowPlant()
    {
        int currentStep = sapling.growSprite.Length - 1;
        int stepLength = currentStep;

        while (currentTime > 0)
        {
            currentTime--;
            //UI적용

            if ((currentTime * stepLength) / sapling.growTime <= currentStep)
            {
                currentStep--;
                plantSprite.sprite = sapling.growSprite[currentStep];
            }

            yield return new WaitForSeconds(1);
        }
        isCompleteGrow = true;
    }

   
}
