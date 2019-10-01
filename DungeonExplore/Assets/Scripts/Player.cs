using System.Collections;
using System.Collections.Generic;

public class Player  {

    public List<Role> Roles;
    public Dictionary<int, int> Techniques = new Dictionary<int, int>();//TechniqueId,Level
    public Dictionary<int, int> Achievements = new Dictionary<int, int>();//AchievementId,Level

    public int[] Materials = new int[] { 0, 0, 0, 0, 0, 0, 0 };//现金、材料1-4、成就点

    public int LastTimeStamp = 0;//上次标记时间戳

    public int AutoCashPerMinute = 100;


}
