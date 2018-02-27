using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bt_Finish : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(changefinal);
	}
    void changefinal()
    {
        Application.LoadLevel("Chat");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
