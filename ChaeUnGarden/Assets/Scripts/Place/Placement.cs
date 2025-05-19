using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Placement : MonoBehaviour
{
    [SerializeField] private Grid grid;
    [SerializeField] private GameObject tileObject;
    [SerializeField] private UIPlantInfo uiPlant;

    private Vector3 clickPos;
    private Vector3 lastPos;

    private bool isEnd = true;
    private bool isOverlap = false;

    void Start()
    {
        
    }

    public void StartSetPlace(GameObject tile)
    {
        tileObject = tile;
        isEnd = false;

        GameObject plantTile = Instantiate(tileObject, clickPos, Quaternion.identity);
        plantTile.GetComponent<Plant>().SetUIComponenet(uiPlant);

        StartCoroutine(SetPlace(plantTile));
    }
    public void EndSetPlace()
    {
        if (!isOverlap)
        {
            isEnd = true;
        }
       
    }
    private IEnumerator SetPlace(GameObject plantTile)
    {
        //반투명

        while (!isEnd)
        {
            if (clickPos == lastPos && !isOverlap)
            {
                //불투명
                EndSetPlace();
            }
            else
            {
                RaycastHit hit;
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                worldPos.z = 0;

                lastPos = clickPos;
                clickPos = WorldToIso(worldPos);
                plantTile.transform.position = clickPos;

                Physics.Raycast(clickPos, transform.forward, out hit, 1f);

                if (!hit.collider.CompareTag("shelf"))
                {
                    //빨간색
                    isOverlap = true;
                }
                else
                {
                    //반투명
                    isOverlap = false;
                }
            }
            yield return new WaitForEndOfFrame();
        }
    }
    private Vector3 WorldToIso(Vector3 worldPos)
    {
        int isoX = Mathf.RoundToInt((worldPos.x));
        float isoY = Mathf.RoundToInt((worldPos.y));

        if (Mathf.Abs(isoX) % 2 == 1) { isoY -= 0.5f; }

        return new Vector3(isoX, isoY, 0);  // Z는 2D 환경에서 0으로 설정
    }
}
