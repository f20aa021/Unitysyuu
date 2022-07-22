using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionVolume : MonoBehaviour
{
    [SerializeField] Slider bgmSlider;
    [SerializeField] TextMeshProUGUI bgmVolumeText;

    [SerializeField] Slider seSlider;
    [SerializeField] TextMeshProUGUI seVolumeText;


    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlayBGM(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBGMSlider()
    {
        AudioManager.GetInstance().BGMVolume = bgmSlider.value;
        bgmVolumeText.text = string.Format("{0:0.00}", bgmSlider.value);
    }

    public void ChangeSESlider()
    {
        AudioManager.GetInstance().SEVolume = seSlider.value;
        seVolumeText.text = string.Format("{0:0.00}", seSlider.value);
    }

    public void SeTestButton()
    {
        AudioManager.GetInstance().PlaySound(0);
    }
}
