using System.Collections;
using System.Collections.Generic;

public class Skill  {

    public int Id;
    public string Name;
    public string Description;

    public SkillType Type;
    public SkillEffect Effect;
    public int BasicValue;
    public int GrowthValue;
}

public enum SkillType
{
    ActiveSkill,
    PassiveSkill
}

public enum SkillEffect{
    Damage,
    AddDamageRate,
    AddAllDamageRate,
    AddDamageReduction,
    AddAllDamageReduction,
    AddExp,
}
