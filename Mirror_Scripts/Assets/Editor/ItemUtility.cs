using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemUtility : Editor{
    [MenuItem("Assets/Create/Mirror/Item")]
    static public void CreateItem() {
        ScriptableObjectUtility.CreateAsset<BaseItem>();
    }
}
