using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btsentable : MonoBehaviour {

	public GameObject success;
	int flag;
	string URL_Login = "http://192.168.1.103/extinguisher/sendresult.php";
	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		success.SetActive(false);
		btn.onClick.AddListener(isLoad);
	    
	}
	public void isLoad()
	{
		
		if (Bt_Pass.conveycount.Count == 9) {
			flag = 0;
		} else 
		{
			flag = 1;
		}
		string place= login.PlaceName;
		string excode = MyVumarkEventHandler.extinger;
		int excondition = flag;
		string checkday = System.DateTime.Now.ToString ();
		if (excode == null) {
			excode = " ";
		}
		//Debug.Log (place);
		//Debug.Log (excode);
		//Debug.Log (excondition);
		//Debug.Log (checkday);
		StartCoroutine(UploadScore(place,excode,excondition,checkday));
	}
	IEnumerator UploadScore(string placename,string excode,int excondition,string checkday)
	{
		WWWForm ws = new WWWForm ();
		ws.AddField ("Place", placename);
		ws.AddField ("Code",excode);
		ws.AddField ("Excond",excondition);
		ws.AddField ("Checkday",checkday);
		WWW registerdownload = new WWW (URL_Login, ws);
		yield return registerdownload;
		Debug.Log (registerdownload.text);
		if (registerdownload.text == "update success") 
		{
			success.SetActive(true);
			Invoke("disappear",1f);
		} 

	}
	void disappear()
	{
		success.SetActive(false);
	}
}
