using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlantInfo : MonoBehaviour
{


    private bool isActive;
    public void SetPosition(Transform plantPos)
    {
        if(isActive == false)
        {
            isActive = true;
            this.gameObject.SetActive(true);
            this.transform.position = Camera.main.WorldToScreenPoint(plantPos.position - Vector3.left);
        }
        else
        {
            isActive = false;
            this.gameObject.SetActive(false);
        }
    }
    public void SetUI(Flower flower)
    {

    }
}
