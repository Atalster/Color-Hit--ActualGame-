using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunsetEquipped : MonoBehaviour
{   

    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("SunsetEquip") == "Equipped")
        {
            textbox.text = "Sunset: Equipped";
        }
        else {
            textbox.text = "Sunset: Not Equipped";
        }

    }
}
