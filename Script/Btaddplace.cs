using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class Btaddplace : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(change_addplace);

	}
	void change_addplace()
	{
		Application.LoadLevel("AddPlace");
	}

	// Update is called once per frame
	void Update () {

	}
}
