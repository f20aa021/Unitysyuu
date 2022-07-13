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

    int count;//ƒJƒEƒ“ƒ^

    string tx;//dt
    int txnum;//tcn

    public GameObject ChoicesPanel;//‘I‘ğˆ
    public GameObject UPbutton;
    public GameObject Downbutton;


    // Start is called before the first frame update

    void Awake()
    {
        Application.targetFrameRate = 10;
    }
    void Start()
    {
        es = Resources.Load("UnityExcelxlsx") as Entity_Sheet1;//Sheet1‚ÍExcel‚ÌSheet1‚ğw‚µ‚Ä‚¢‚é
    }

    // Update is called once per frame
    void Update()
    {
        if (es.sheets[0].list[4].name != es.sheets[0].list[count].name)
        {
            if (txnum != es.sheets[0].list[count].name.Length)//’·‚³
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//‘«‚µ‚Ä‚¢‚­
                tmp.text = tx;//•\¦
                txnum++;
                if (es.sheets[0].list[1].name == es.sheets[0].list[count].name)
                {
                    ChoicesPanel.SetActive(true);
                }

            }
            else
            {
                if (count != es.sheets[0].list[count].name.Length - 1)//’·‚³‚ª‚R‚È‚ç—v‘f”‚Í‚Q‚Ü‚Å‚¾‚©‚ç
                {
                    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                    {
                        txnum = 0;//‰Šú‰»
                        tx = "";//‰Šú‰»
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
        txnum = 0;//‰Šú‰»
        tx = "";//‰Šú‰»

        if (txnum != es.sheets[0].list[count].name.Length)//’·‚³
        {
            while (txnum != es.sheets[0].list[count].name.Length)
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//‘«‚µ‚Ä‚¢‚­
                tmp.text = tx;//•\¦
                txnum++;
            }
        }
        else
        {
            if (count != es.sheets[0].list[count].name.Length - 1)//’·‚³‚ª‚R‚È‚ç—v‘f”‚Í‚Q‚Ü‚Å‚¾‚©‚ç
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                {
                    txnum = 0;//‰Šú‰»
                    tx = "";//‰Šú‰»
                    count++;
                }
            }
        }

        }
}
