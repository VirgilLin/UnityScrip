using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSimple : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button bt = gameObject.GetComponent<Button>();
        bt.onClick.AddListener(changelevel);
		
	}
    void changelevel()
    {
        Application.LoadLevel("Samples");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
