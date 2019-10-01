using System.Collections;
using System.Collections.Generic;

public class Role{

    public int Index;
    public int RoleType;

    public int Level;
    public int Exp;
    public Dictionary<int, int> RoleSkills = new Dictionary<int, int>();//SkillId, SkillLevel
    public int DungeonLevel;
}
