using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : ScriptableObject{

    //Class Details
    public int classId;
    public string className;
    public string classDesc;

    //Class Skills
    public Skill upSkill_1;
    public Skill upSkill_2;
    public Skill upSkill_3;
    public Skill neutralSkill_1;
    public Skill neutralSkill_2;
    public Skill neutralSkill_3;
    public Skill powerSkill_1;
    public Skill powerSkill_2;
    public Skill powerSkill_3;
    public Skill downSkill_1;
    public Skill downSkill_2;
    public Skill downSkill_3;
   
}
