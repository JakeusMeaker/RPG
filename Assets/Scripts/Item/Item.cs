using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject {

    public int cost;
    public int weight;
    public int durability;

    public Enums.ItemType itemType;
    public Enums.EffectType effect;
}
