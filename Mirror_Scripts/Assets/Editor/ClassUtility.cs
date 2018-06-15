using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ClassUtility : Editor{
    [MenuItem("Assets/Create/Mirror/Class")]
    static public void CreateClass() {
        ScriptableObjectUtility.CreateAsset<BaseCharacterClass>();
    }
}
