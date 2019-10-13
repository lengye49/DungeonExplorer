using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class GameManager : MonoBehaviour {

    private float[] t = new float[4];
    private Role[] roles;

    void Start () {
        //展示时间测试
        StartCoroutine(GetTime());

        //玩家是否创建账号
        if (PlayerData._playerInfo.PlayerRoles.Count==0) {
            Debug.Log("创建新账号....");
        }
        else {
            Debug.Log("已有角色数量 = " + PlayerData._playerInfo.PlayerRoles.Count);
        }


    }



    void Update () {
        //TimeChange(Time.deltaTime);       
    }

    void TimeChange(float deltaT) {
        for (int i = 0; i < 4; i++)
        { 
            t[i] += deltaT;
            if (roles[i].RoleAction == CharacterAction.Searching) {
                //改变探索进度条
                if (t[i] >= roles[i].SearchCD) {
                    t[i] -= roles[i].SearchCD;
                    Debug.Log("Role " + i + " Finish SearchCD");
                }
            }
            else if(roles[i].RoleAction == CharacterAction.Digging)
            {
                //改变挖掘进度条
                if (t[i] >= roles[i].DiggingCD)
                {
                    t[i] -= roles[i].DiggingCD;
                    Debug.Log("Role " + i + " Finish DigCD");
                }
            }
            else if(roles[i].RoleAction==CharacterAction.Fighting)
            {
                //改变技能进度条
                if (t[i] >= roles[i].SkillCD)
                {
                    t[i] -= roles[i].SkillCD;
                    Debug.Log("Role " + i + " Finish SkillCD");
                }
            }
            else { Debug.Log("Role " + i + " Has Wrong Action Type" + roles[i].RoleAction); }

        }
    }





    IEnumerator GetTime()
    {
        string timeStr;

        WWW www = new WWW("http://www.hko.gov.hk/cgi-bin/gts/time5a.pr?a=1");
        yield return www;

        if (www.text == "" || www.text.Trim() == "")//如果获取网络时间失败,改为获取系统时间
        {
            timeStr = "LocalTime = " + System.DateTime.Now.Month + "/" + System.DateTime.Now.Day + " "
                            + System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second;
        }
        else//成功获取网络时间
        {
            timeStr = www.text.Substring(2);
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = System.TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddMilliseconds(System.Convert.ToDouble(timeStr));
            timeStr = time.ToString();
            timeStr = "WWW Time = " + time.Month + "/" + time.Day + " " + time.Hour + ":" + time.Minute + ":" + time.Second;
        }
        Debug.Log(timeStr);
    }
}



