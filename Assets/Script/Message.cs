using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    int count;
    string a;

    string tx;
    int txnum;

    // Start is called before the first frame update
    void Start()
    {
        a =tmp.text = "表示させたい文字列";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
