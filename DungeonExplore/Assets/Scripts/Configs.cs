﻿using UnityEngine;

public static class Configs  {

    public static Vector2[] DungenCellPos = new Vector2[]{
        new Vector2(-400,748),new Vector2(-140,750),new Vector2(130,750),new Vector2(400,750),
        new Vector2(-400,550),new Vector2(-140,550),new Vector2(130,550),new Vector2(400,550),
        new Vector2(-400,360),new Vector2(-140,360),new Vector2(130,360),new Vector2(400,360),
        new Vector2(-400,160),new Vector2(-140,160),new Vector2(130,160),new Vector2(400,160)
    };

    public static int ExploringMaxNum = 4;
    public static int RoleNum = 10;
    public static string[] RoleProfessions = new string[] { 
        "Warrior","Shooter","Knight","Thief","Priest","LandWizard","FireWizard","IceWizard","WindWizard","Dragon" };

    public static int[,] RoleSkills = new int[,] {
        {1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},
        {1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},{1,2,3,4,5,6,7,8,9,10},
    };
}
