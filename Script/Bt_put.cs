using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class Bt_put : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ChangePut);
	}
    void ChangePut()
    {
		Application.LoadLevel("Video_Test");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
