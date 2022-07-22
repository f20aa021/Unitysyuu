using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelOP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionButtonOnClick()
    {
        panelOP.SetActive(true);
        panel.SetActive(false);
        
    }

    public void BackButtonOnClick()
    {
        panelOP.SetActive(false);
        panel.SetActive(true);

    }
}
