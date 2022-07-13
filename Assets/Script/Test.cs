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

    int count;//�J�E���^

    string tx;//dt
    int txnum;//tcn

    public GameObject ChoicesPanel;//�I����
    public GameObject UPbutton;
    public GameObject Downbutton;


    // Start is called before the first frame update

    void Awake()
    {
        Application.targetFrameRate = 10;
    }
    void Start()
    {
        es = Resources.Load("UnityExcelxlsx") as Entity_Sheet1;//Sheet1��Excel��Sheet1���w���Ă���
    }

    // Update is called once per frame
    void Update()
    {
        if (es.sheets[0].list[4].name != es.sheets[0].list[count].name)
        {
            if (txnum != es.sheets[0].list[count].name.Length)//����
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//�����Ă���
                tmp.text = tx;//�\��
                txnum++;
                if (es.sheets[0].list[1].name == es.sheets[0].list[count].name)
                {
                    ChoicesPanel.SetActive(true);
                }

            }
            else
            {
                if (count != es.sheets[0].list[count].name.Length - 1)//�������R�Ȃ�v�f���͂Q�܂ł�����
                {
                    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                    {
                        txnum = 0;//������
                        tx = "";//������
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
        txnum = 0;//������
        tx = "";//������

        if (txnum != es.sheets[0].list[count].name.Length)//����
        {
            while (txnum != es.sheets[0].list[count].name.Length)
            {
                tx = tx + es.sheets[0].list[count].name[txnum];//�����Ă���
                tmp.text = tx;//�\��
                txnum++;
            }
        }
        else
        {
            if (count != es.sheets[0].list[count].name.Length - 1)//�������R�Ȃ�v�f���͂Q�܂ł�����
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(1))
                {
                    txnum = 0;//������
                    tx = "";//������
                    count++;
                }
            }
        }

        }
}
