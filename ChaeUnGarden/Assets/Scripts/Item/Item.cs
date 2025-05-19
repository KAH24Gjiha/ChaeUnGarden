using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[Serializable]
public class Item : ScriptableObject
{
    public string Name;
    public string Info;
    public ItemType itemType;

    public bool isLock;
    public int Amount;
    public int Price;

    public Sprite icon;

    public int index;

}
