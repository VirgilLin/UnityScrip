using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class login : MonoBehaviour {
    public Toggle remPasswd;
    public Toggle fogPasswd;
    public InputField inputName;
    public InputField inputPaswd;
    public InputField inputPlace;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    //public GameObject load;
    public static string PlaceName;
	string URL_Login = "http://192.168.1.103/extinguisher/userlogin.php";
    // Use this for initialization
    void Start () {
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
		//load.SetActive(false);
        inputName.text = PlayerPrefs.GetString("account");
        inputPaswd.text = PlayerPrefs.GetString("password");
    }
	
	// Update is called once per frame
	void Update () {
        if (remPasswd.isOn)
        {
            PlayerPrefs.SetString("account", inputName.text);
            PlayerPrefs.SetString("password", inputPaswd.text);

        }
        else if (fogPasswd.isOn)
        {
            PlayerPrefs.SetString("account", "");
            PlayerPrefs.SetString("password", "");
            //inputName.text = "";
            inputPaswd.text = "";

        }

    }
    public void isLoad()
    {
		PlaceName = inputPlace.text;
        string nameText = inputName.text;
        string pwdText = inputPaswd.text;
        string placeText = inputPlace.text;
		StartCoroutine(UploadScore(nameText, pwdText,placeText));
    }
	IEnumerator UploadScore(string username,string userpassword,string place)
	{
		WWWForm ws = new WWWForm ();//Create a upload object
		ws.AddField ("PlayerName", username);
		ws.AddField ("PlayerPwd", userpassword);
		ws.AddField ("Place",place);
		WWW logindownload = new WWW (URL_Login,ws);//upload the form
		yield return logindownload;//return the page
		if (logindownload.text == "login success") {
			text4.SetActive (true);
			Invoke ("disappear", 1f);
			Application.LoadLevel("Chapter_2");
			Debug.Log (logindownload.text);
			Debug.Log ("登陆成功");
		} else if (logindownload.text == "No place") {
			text5.SetActive (true);
			Invoke ("disappear", 1f);
			//Debug.Log (logindownload.text);
			Debug.Log ("无此地点");
		} else if (logindownload.text == "No user")
		{
			text6.SetActive(true);
			Invoke("disappear",1f);
			Debug.Log ("用户名或密码错误");
		}
	}

	void disappear()
	{
		text4.SetActive(false);
		text5.SetActive(false);
		text6.SetActive(false);
	}

}
