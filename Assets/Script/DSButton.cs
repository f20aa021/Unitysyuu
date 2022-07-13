using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSButton : MonoBehaviour
{
    GameObject DButton;
    bool dsp;

    public Test test;

    public GameObject UPbutton;
    public GameObject Downbutton;

    void Start()
    {
        
    }
    

    public void DButtontest()
    {

        if (dsp == true)
        {
            Application.targetFrameRate = 10;
            dsp = false;


        }
        else
        {
            Application.targetFrameRate = 60;
            dsp = true;

        }
    }
}
