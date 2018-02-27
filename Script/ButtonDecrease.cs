using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDecrease : MonoBehaviour {

    public GameObject texthead;
    public GameObject texttail;
	// Use this for initialization
	void Start () {
        texthead.SetActive(false);
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(Decrease);
    }
    void Decrease()
    {
        if (ButtonCount.count > 0)
        {
            texttail.SetActive(false);
            ButtonCount.count--;
            Debug.Log(ButtonCount.count);
            
        }
        else
        {
            Debug.Log("已经是第一个步骤");
            texthead.SetActive(true);
            Invoke("disappear", 1f);
        }
    }
    void disappear()
    {
        texthead.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

		
	}
}
