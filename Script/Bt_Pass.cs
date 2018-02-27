using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bt_Pass : MonoBehaviour {
    public static ArrayList conveycount =new ArrayList();
    public GameObject record;
    public GameObject beencheck;
    //private int i=0;
	// Use this for initialization
	void Start ()
    {
        conveycount.Clear();//初始化
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(test);
        record.SetActive(false);
        beencheck.SetActive(false);
	}
    void test()
    {
        int id=conveycount.IndexOf(ButtonCount.count);
        if (id == -1)
        {
            conveycount.Add(ButtonCount.count);
            record.SetActive(true);
            Invoke("disappear", 1f);
            Debug.Log("已记录");
        }
        else
        {
            beencheck.SetActive(true);
            Invoke("disappears", 1f);
            Debug.Log("该项目已检查过");
        }
        

    }
    void disappear()
    {
        record.SetActive(false);
    }
    void disappears()
    {
       beencheck.SetActive(false);
    }
    // Update is called once per frame
    void Update ()
    {

		
	}
}
