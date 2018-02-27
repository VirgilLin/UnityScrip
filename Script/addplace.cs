using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addplace : MonoBehaviour {
	
	public InputField inputplace;
	public GameObject fail;
	public GameObject success;
	public GameObject empty;
	string URL_Login = "http://192.168.1.103/extinguisher/coninsert.php";
	// Use this for initialization
	void Start ()
	{
		fail.SetActive(false);
		success.SetActive(false);
		empty.SetActive(false);
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(isLoad);
	}
	public void isLoad()
	{
		string placeText = inputplace.text;
		if (placeText == "") {
			empty.SetActive (true);
			Invoke ("disappear", 1f);
			Debug.Log ("注册错误");
		} else {
			StartCoroutine (UploadScore (placeText));
		}
	}
	IEnumerator UploadScore(string placename)
	{
		WWWForm ws = new WWWForm ();
		ws.AddField ("InputPlace", placename);
		WWW registerdownload = new WWW (URL_Login, ws);
		yield return registerdownload;
		if (registerdownload.text == "been") 
		{
			fail.SetActive(true);
			Invoke("disappear", 1f);
			Debug.Log ("该用户名已被注册");
		} else if (registerdownload.text == "success")
		{
			success.SetActive(true);
			Invoke("disappear", 1f);
			Debug.Log ("注册成功");
		}

	}
	void disappear()
	{
		fail.SetActive(false);
		success.SetActive(false);
		empty.SetActive(false);
	}
}
