using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        Bone,
        Stone,
        Meat
    }

    public ItemType itemType;
    public int amount;
}
