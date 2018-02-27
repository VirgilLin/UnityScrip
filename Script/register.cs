using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class register : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public InputField Name;
	public InputField Pwd;
	// Use this for initialization
	void Start () {
		text1.SetActive(false);
		text2.SetActive(false);
		text3.SetActive(false);
		
	}
	string URL_Login = "http://192.168.1.103/extinguisher/userregister.php";
	public void isLoad()
	{
		string nameText = Name.text;
		string pwdText = Pwd.text;
		if (nameText == "" || pwdText == "") {
			text3.SetActive (true);
			Invoke ("disappear", 1f);
			Debug.Log ("注册错误");
		} else {
			StartCoroutine (UploadScore (nameText, pwdText));
		}
	}
	IEnumerator UploadScore(string username,string userpassword)
	{
		WWWForm ws = new WWWForm ();
		ws.AddField ("InputName", username);
		ws.AddField ("InputPwd", userpassword);
		WWW registerdownload = new WWW (URL_Login, ws);
		yield return registerdownload;
		if (registerdownload.text == "been") 
		{
			text1.SetActive(true);
			Invoke("disappear", 1f);
			Debug.Log ("该用户名已被注册");
		} else if (registerdownload.text == "success")
		{
			text2.SetActive(true);
			Invoke("disappear", 1f);
			Debug.Log ("注册成功");
		}
		else
		{
			text3.SetActive(true);
			Invoke("disappear",1f);
			Debug.Log ("注册错误");
		}
	}
	void disappear()
	{
		text1.SetActive(false);
		text2.SetActive(false);
		text3.SetActive(false);
	}

}
