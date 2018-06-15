using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkillUtility : Editor{
    [MenuItem("Assets/Create/Mirror/Skill")]
    static public void CreateSKill() {
        ScriptableObjectUtility.CreateAsset<Skill>();
    }
}
