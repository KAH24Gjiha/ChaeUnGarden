using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Character : ScriptableObject
{
    public string characterName;
    public string characterInfo;
    public int characterIndex;

    public int friendShip;
    public int[] friendShipGauge;

    public Flower[] signatureFlower;
    public Sprite faceSprite;

    public Order[] orders;

    public GameObject characterModel;
}
