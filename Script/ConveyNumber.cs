using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyNumber : MonoBehaviour {
    public GameObject image0;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    // Use this for initialization
    void Start ()
    {
        foreach (int a in Bt_Pass.conveycount)
        {
            if (a == 0)
            {
                image0.SetActive(false);
            }
            if (a == 1)
            {
                image1.SetActive(false);
            }
            if (a == 2)
            {
                image2.SetActive(false);
            }
            if (a == 3)
            {
                image3.SetActive(false);
            }
            if (a == 4)
            {
                image4.SetActive(false);
            }
            if (a == 5)
            {
                image5.SetActive(false);
            }
            if (a == 6)
            {
                image6.SetActive(false);
            }
            if (a == 7)
            {
                image7.SetActive(false);
            }
            if (a == 8)
            {
                image8.SetActive(false);
            }
        }
        //Debug.Log(Bt_Pass.conveycount);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
