using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bt_Back2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Changlevel);
	}
    void Changlevel()
    {

        Application.LoadLevel("Chapter_2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
