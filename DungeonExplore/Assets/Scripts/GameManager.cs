using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class GameManager : MonoBehaviour {

	
	void Start () {
        StartCoroutine(GetTime());
    }
	
	// Update is called once per frame
	void Update () {
       
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

