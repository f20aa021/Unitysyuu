using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using TMPro;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    Entity_Sheet1 es;

    int count;//カウンタ

    string tx;//dt
    int txnum;//tcn

    public GameObject ChoicesPanel;//選択肢
    public GameObject UPbutton;
    public GameObject Downbutton;


    // Start is called before the first frame update

    void Awake()
    {
        Application.targetFrameRate = 10;
    }
    void Start()
    {
        es = Resources.Load("UnityExcelxlsx") as Entity_Sheet1;//Sheet1はExcelのSheet1を指している
    }

    // Update is called once per frame
    void Update()
    {
        if (es.sheets[0].list[4].name != es.sheets[0].list[count].name)
        {
            if (txnum != es.sheets[0].list[count].name.Length)//長さ
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//足していく
                tmp.text = tx;//表示
                txnum++;
                if (es.sheets[0].list[1].name == es.sheets[0].list[count].name)
                {
                    ChoicesPanel.SetActive(true);
                }

            }
            else
            {
                if (count != es.sheets[0].list[count].name.Length - 1)//長さが３なら要素数は２までだから
                {
                    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                    {
                        txnum = 0;//初期化
                        tx = "";//初期化
                        count++;
                    }
                }
            }
        }
    }

    public void UPButtonON()
    {
        count++;
        ChoicesPanel.SetActive(false);
        txnum = 0;//初期化
        tx = "";//初期化

        if (txnum != es.sheets[0].list[count].name.Length)//長さ
        {
            while (txnum != es.sheets[0].list[count].name.Length)
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//足していく
                tmp.text = tx;//表示
                txnum++;
            }
        }
        else
        {
            if (count != es.sheets[0].list[count].name.Length - 1)//長さが３なら要素数は２までだから
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                {
                    txnum = 0;//初期化
                    tx = "";//初期化
                    count++;
                }
            }
        }

        }
}
