using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;

public class Loadhistory : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(chagelevel);
	}
    void chagelevel()
    {
        //Debug.Log("????");
		Application.LoadLevel("History");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
