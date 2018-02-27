using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class Bt_Check : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ChangeCheck);
	}
    void ChangeCheck()
    {
		Application.LoadLevel("vumark_test");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
