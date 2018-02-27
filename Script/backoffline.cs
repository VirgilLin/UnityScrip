using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class backoffline : MonoBehaviour {

	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(changelevel);
	}
	void changelevel()
	{
		Application.LoadLevel("Begining");
	}

	// Update is called once per frame
	void Update () {

	}
}
