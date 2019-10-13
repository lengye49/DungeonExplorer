using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerData : MonoBehaviour
{
    public static PlayerInfo _playerInfo;

    void Awake()
    {
        _playerInfo = new PlayerInfo();

        Debug.Log("Loading PlayerData...");
        LoadData();
    }


    #region 存储/加载数据
    public static void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/info.dat");
        bf.Serialize(file, _playerInfo);
        file.Close();
    }

    void LoadData()
    {
        //测试，删除数据
        File.Delete(Application.persistentDataPath + "/info.dat");

        if (File.Exists(Application.persistentDataPath + "/info.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/info.dat", FileMode.Open);
            _playerInfo = (PlayerInfo)bf.Deserialize(file);
            file.Close();
            Debug.Log("加载成功！");
        }
        else
        {
            InitPlayerInfo();
            TestAddRoles();
            SaveData();
        }
    }

    #endregion

    #region 初始化角色数据
    void InitPlayerInfo()
    {

        _playerInfo.PlayerRoles = new List<Role>();

        _playerInfo.TeamInfo = "";

        _playerInfo.Techs = "";
        _playerInfo.Achievements = "";
        _playerInfo.Mats = "0,0,0,0,0,0";
    }

    #endregion

    //测试开启角色
    void TestAddRoles() { 
        for(int i = 0; i < 2; i++) {
            //Debug.Log("添加角色" + (i + 1));
            _playerInfo.PlayerRoles.Add(new Role(i));
        }
    }
}

[System.Serializable]
public class PlayerInfo
{
    //卡牌信息
    public List<Role> PlayerRoles;

    //参战成员
    public string TeamInfo;

    //玩家信息
    public string Techs;
    public string Achievements;
    public string Mats;
}

[System.Serializable]
public class Role
{
    public int Id;
    public int Level;
    public int Exp;
    public string SkillLevel;
    public int DungeonLevel;

    public CharacterAction RoleAction;
    public float SearchCD;
    public float DiggingCD;

    public float SkillCD;
    public float ForwardShake;
    public float AfterShake;

    public Role(int id) {
        Id = id;
        Level = 1;
        Exp = 0;
        SkillLevel = "";
        DungeonLevel = 0;

        RoleAction = CharacterAction.None;
        SearchCD = 100f;
        DiggingCD = 100f;
        SkillCD = 100f;
        ForwardShake = 100f;
        AfterShake = 100f;
    }
}

[System.Serializable]
public enum CharacterAction
{
    None,
    Fighting,
    Searching,
    Digging
}

