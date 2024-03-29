﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoadTxt
{
    private string[][] strs;

    //public Npc ReadNpc(int npcId)
    //{
    //    if (NpcPool.ContainsKey(npcId))
    //        return NpcPool[npcId];

    //    strs = ReadTxtFile("Spec/Npc");
    //    for (int i = 0; i < strs.Length - 1; i++)
    //    {
    //        int id = int.Parse(GetDataByRowAndCol(strs, i + 1, 0));
    //        if (id != npcId)
    //            continue;
    //        string npcname = GetDataByRowAndCol(strs, i + 1, 1);
    //        string desc = GetDataByRowAndCol(strs, i + 1, 2);
    //        int level = int.Parse(GetDataByRowAndCol(strs, i + 1, 3));
    //        int levelInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 4));
    //        int gender = int.Parse(GetDataByRowAndCol(strs, i + 1, 5));
    //        int dialogues = int.Parse(GetDataByRowAndCol(strs, i + 1, 6));
    //        int model = int.Parse(GetDataByRowAndCol(strs, i + 1, 7));
    //        int image = int.Parse(GetDataByRowAndCol(strs, i + 1, 8));
    //        int[] skills = Algorithms.SplitStrToInts(GetDataByRowAndCol(strs, i + 1, 9));
    //        int[] friends = Algorithms.SplitStrToInts(GetDataByRowAndCol(strs, i + 1, 10));
    //        int mate = int.Parse(GetDataByRowAndCol(strs, i + 1, 11));
    //        int[] enemies = Algorithms.SplitStrToInts(GetDataByRowAndCol(strs, i + 1, 12));
    //        string[] nickNames = Algorithms.SplitStrToStrs(GetDataByRowAndCol(strs, i + 1, 13));
    //        Npc npc = new Npc(id, npcname, desc, level, levelInc, gender, dialogues, model, image, skills, friends, mate, enemies, nickNames);
    //        NpcPool.Add(id, npc);
    //        return npc;
    //    }
    //    Debug.Log("Npc " + npcId + " does NOT exist!");
    //    return null;
    //}

    //public NpcModel ReadNpcModel(int modelId)
    //{
    //    strs = ReadTxtFile("Spec/NpcModel");
    //    for (int i = 0; i < strs.Length - 1; i++)
    //    {
    //        int id = int.Parse(GetDataByRowAndCol(strs, i + 1, 0));
    //        if (id != modelId)
    //            continue;
    //        int hp = int.Parse(GetDataByRowAndCol(strs, i + 1, 1));
    //        int hpInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 2));
    //        int mp = int.Parse(GetDataByRowAndCol(strs, i + 1, 3));
    //        int mpInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 4));
    //        int atk = int.Parse(GetDataByRowAndCol(strs, i + 1, 5));
    //        int atkInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 6));

    //        NpcModel model = new NpcModel(id, hp, hpInc, mp, mpInc, atk, atkInc);
    //        return model;
    //    }
    //    Debug.Log("NpcModel " + modelId + " does NOT exist!");
    //    return null;
    //}




    //public NpcTitle ReadNpcTitle(int titleId)
    //{
    //    strs = ReadTxtFile("Spec/NpcTitle");
    //    for (int i = 0; i < strs.Length - 1; i++)
    //    {
    //        int id = int.Parse(GetDataByRowAndCol(strs, i + 1, 0));
    //        if (id != titleId)
    //            continue;
    //        string titlename = GetDataByRowAndCol(strs, i + 1, 1);
    //        int hpBonus = int.Parse(GetDataByRowAndCol(strs, i + 1, 2));
    //        int mpBonus = int.Parse(GetDataByRowAndCol(strs, i + 1, 3));
    //        int atkBonus = int.Parse(GetDataByRowAndCol(strs, i + 1, 4));
    //        int defBonus = int.Parse(GetDataByRowAndCol(strs, i + 1, 5));
    //        int speedBonus = int.Parse(GetDataByRowAndCol(strs, i + 1, 6));

    //        NpcTitle title = new NpcTitle(id, titlename, hpBonus, mpBonus, atkBonus, defBonus, speedBonus);
    //        return title;
    //    }
    //    Debug.Log("NpcModel " + titleId + " does NOT exist!");
    //    return null;
    //}


    //public Skill ReadSkill(int skillId)
    //{
    //    if (SkillPool.ContainsKey(skillId))
    //        return SkillPool[skillId];

    //    strs = ReadTxtFile("Spec/Skill");
    //    for (int i = 0; i < strs.Length - 1; i++)
    //    {
    //        int id = int.Parse(GetDataByRowAndCol(strs, i + 1, 0));
    //        if (id != skillId)
    //            continue;
    //        string skillName = GetDataByRowAndCol(strs, i + 1, 1);
    //        string skillDesc = GetDataByRowAndCol(strs, i + 1, 2);
    //        int type = int.Parse(GetDataByRowAndCol(strs, i + 1, 3));
    //        float sing = float.Parse(GetDataByRowAndCol(strs, i + 1, 4));
    //        float cd = float.Parse(GetDataByRowAndCol(strs, i + 1, 5));
    //        int costType = int.Parse(GetDataByRowAndCol(strs, i + 1, 6));
    //        int costValue = int.Parse(GetDataByRowAndCol(strs, i + 1, 7));
    //        int power = int.Parse(GetDataByRowAndCol(strs, i + 1, 8));
    //        int powerInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 9));
    //        int buffType = int.Parse(GetDataByRowAndCol(strs, i + 1, 10));
    //        int buffParam = int.Parse(GetDataByRowAndCol(strs, i + 1, 11));
    //        int buffParamInc = int.Parse(GetDataByRowAndCol(strs, i + 1, 12));
    //        int range = int.Parse(GetDataByRowAndCol(strs, i + 1, 13));
    //        int sprite = int.Parse(GetDataByRowAndCol(strs, i + 1, 14));

    //        Skill skill = new Skill(id, skillName, skillDesc, type, sing, cd, costType, costValue, power, powerInc, buffType, buffParam, buffParamInc, range, sprite);
    //        SkillPool.Add(id, skill);
    //        return skill;
    //    }
    //    Debug.Log("Skill " + skillId + " does NOT exist!");
    //    return null;
    //}



    public string[][] ReadTxtFile(string fileName)
    {
        string[][] textArray;
        TextAsset binAsset = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;
        string[] lineArray = binAsset.text.Split("\r"[0]);//split the txt by return("/r"[0]);

        textArray = new string[lineArray.Length][];

        for (int i = 0; i < lineArray.Length; i++)
        {
            textArray[i] = lineArray[i].Split(','); //split the line by ','
        }

        return textArray;

    }

    //只有一列数据的txt
    public string[] ReadSingleTxtFile(string fileName)
    {
        TextAsset binAsset = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;
        string[] lineArray = binAsset.text.Split("\r"[0]);//split the txt by return("/r"[0]);
        return lineArray;
    }

    public string GetDataByRowAndCol(string[][] textArray, int nRow, int nCol)
    {
        if (textArray.Length <= 0 || nRow >= textArray.Length)
            return "";
        if (nCol >= textArray[0].Length)
            return "";

        return textArray[nRow][nCol];
    }
}