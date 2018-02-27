using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class BtBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ChangeLevel);
		
	}
    void ChangeLevel()
    {
		Application.LoadLevel("Samples");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
