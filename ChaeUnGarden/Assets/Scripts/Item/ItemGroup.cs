using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[Serializable]
public class ItemGroup : ScriptableObject
{
    public List<Item> group;
}
