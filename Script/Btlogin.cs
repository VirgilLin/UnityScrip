﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btlogin : MonoBehaviour {


	// Use this for initialization
	public login other;
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
