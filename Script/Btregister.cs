using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btregister : MonoBehaviour {

	public register other;
	// Use this for initialization
	void Start () {
		Button btn = this.GetComponent<Button> ();
		btn.onClick.AddListener (OnClick);
	}
	void OnClick()
	{
		other.isLoad ();
	}

	// Update is called once per frame
	void Update () {

	}
}
