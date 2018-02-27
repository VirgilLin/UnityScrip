using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveTest : MonoBehaviour {
    // Use this for initialization
    public GameObject gauge;
    public GameObject tube;
    public GameObject logo;
    public GameObject insure;
    public GameObject holder;
    public GameObject neck;
    public GameObject body;
    public GameObject mouth;
    public GameObject noodle;
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    void Start ()
    {

	}


    // Update is called once per frame
    void Update()
    {
        if (ButtonCount.count == 0)
        {
            gauge.SetActive(true);
            
            noodle.SetActive(false);
            tube.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            body.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(true);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 1)
        {
            noodle.SetActive(true);
            gauge.SetActive(false);
            tube.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            body.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 2)
        {
             insure.SetActive(true);
             noodle.SetActive(false);
             tube.SetActive(false);
             logo.SetActive(false);
             gauge.SetActive(false);
             holder.SetActive(false);
             neck.SetActive(false);
             body.SetActive(false);
             mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(true);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 3)
        {
            tube.SetActive(true);
            noodle.SetActive(false);
            gauge.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            body.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 4)
        {
            mouth.SetActive(true);
            noodle.SetActive(false);
            tube.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            body.SetActive(false);
            gauge.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(true);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 5)
        {
            holder.SetActive(true);
            noodle.SetActive(false);
            tube.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            gauge.SetActive(false);
            neck.SetActive(true);
            body.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(true);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 6)
        {
            body.SetActive(true);
            noodle.SetActive(false);
            tube.SetActive(false);
            logo.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            gauge.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(true);
            text7.SetActive(false);
            text8.SetActive(false);
        }
        if(ButtonCount.count==7)
        {
            logo.SetActive(true);
            noodle.SetActive(false);
            tube.SetActive(false);
            gauge.SetActive(false);
            insure.SetActive(false);
            holder.SetActive(false);
            neck.SetActive(false);
            body.SetActive(false);
            mouth.SetActive(false);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(true);
            text8.SetActive(false);
        }
        if (ButtonCount.count == 8)
        {
            gauge.SetActive(true);
            noodle.SetActive(true);
            tube.SetActive(true);
            logo.SetActive(true);
            insure.SetActive(true);
            holder.SetActive(true);
            neck.SetActive(true);
            body.SetActive(true);
            mouth.SetActive(true);
            text0.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(true);
        }

    }
    /*private void Ontop()
    {
        if (ButtonCount.count == 1)
        {
            cube.SetActive(true);
        }
        if (ButtonCount.count == 0)
        {
            cube.SetActive(false);
        }
    }*/
}
