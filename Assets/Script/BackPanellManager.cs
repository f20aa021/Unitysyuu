using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;

public class BackPanellManager: MonoBehaviour
{
    Image backp;
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetAsync<Sprite>("Assets/Images/kari.png").Completed += sprite =>
        {
            backp = GetComponent<Image>();
            backp.sprite = Instantiate(sprite.Result);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //asdfghjklasdfghjklaa
}
