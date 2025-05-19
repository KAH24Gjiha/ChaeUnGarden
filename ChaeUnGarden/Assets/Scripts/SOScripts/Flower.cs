using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Level
{
    public int getAmount;
    public int needPrice;
}

[CreateAssetMenu]
public class Flower : Item
{
    public int flowerLevel;
    public Level[] levelDetail;

    public Sprite[] flowerImage;
    public FlowerType flowerType;
    public ColorType colorType;
    public PositionType positionType;
}
