using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCount : MonoBehaviour {
    static public int count=0;
    public GameObject texthead;
    public GameObject texttail;
	// Use this for initialization
	void Start () {
        count = 0;
        texttail.SetActive(false);
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Count);
	}
    void Count()
    {
        if (count < 8)
        {
            count++;
            Debug.Log(count);
            texthead.SetActive(false);
        }
        else
        {
            Debug.Log("已经是最后一步");
            texttail.SetActive(true);
            Invoke("disappear", 1f);
        }
    }
    void disappear()
    {
        texttail.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
