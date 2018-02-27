using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
//using Mono.Data.Sqlite;
//using MySql.Data.MySqlClient;
//using MySql.Data;

public class ReadTable : MonoBehaviour {
    //private SqlAccess sql;
	string URL_Login = "http://192.168.1.103/extinguisher/readtable.php";
    public GameObject Row_Prefab;
    // Use this for initialization
    void Start ()
    {
        //sql = new SqlAccess();
        //MySqlDataReader reader= sql.ReadFullTable("table2");
		StartCoroutine(UploadScore());
    }
	IEnumerator UploadScore()
	{
		WWW w = new WWW (URL_Login);
		yield return w;
		JsonData jdata = JsonMapper.ToObject(w.text);
		for (int i = 0; i < jdata.Count; i++)
		{
			int j = 0;
			string con;
			GameObject table = GameObject.Find("table");
			GameObject row = GameObject.Instantiate(Row_Prefab,table.transform.position,table.transform.rotation);
			int flag = int.Parse(jdata [i] ["cond"].ToString());
			if (flag == 0)
				con = "正常";
			else if (flag == 1)
				con = "故障";
			else
				con = "未检查";
			row.name = "row" + (j+1);
			row.transform.SetParent(table.transform);
			row.transform.localScale = Vector3.one;
			row.transform.Find ("Place").GetComponent<Text> ().text = jdata [i] ["place"].ToString();
			row.transform.Find("Equipment").GetComponent<Text>().text = jdata [i] ["code"].ToString();
			row.transform.Find("Condition").GetComponent<Text>().text = con;
			row.transform.Find("Date").GetComponent<Text>().text = jdata [i] ["date"].ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
