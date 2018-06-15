using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : ScriptableObject {

    public int itemId;
    public string itemName;
    public string itemDesc;
    public ItemType itemType;
    public Element itemElement;
}
