using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loadoffline : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(changelevel);
		
	}
    void changelevel()
    {
        Debug.Log("???");
        Application.LoadLevel("vumark-offline");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
