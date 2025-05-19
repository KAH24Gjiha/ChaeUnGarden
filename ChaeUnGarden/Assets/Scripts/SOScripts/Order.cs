using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Order : ScriptableObject
{
    public Character orderer;
    public Sprite ordererImage;
    public string orderName;
    public string[] orderDetail;

    public BouquetType requestType;
    public SizeType requestSize;
    public ColorType colorType;
    public FlowerType flowerType;

    public Flower[] signatureFlower;

    public int budget;

    public int orderIndex;
}
