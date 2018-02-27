using System.Collections;
using System.Collections.Generic;
//using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Bt_Error : MonoBehaviour {

    public GameObject record;
	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        record.SetActive(false);
        btn.onClick.AddListener(sign);
	}
    void sign()
    {
        record.SetActive(true);
        Invoke("disappear",1f);
        //Thread.Sleep(3*1000);
        //record.SetActive(false);
        Debug.Log("已记录");
    }
    void disappear()
    {
        record.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
