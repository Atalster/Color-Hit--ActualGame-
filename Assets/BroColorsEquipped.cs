using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BroColorsEquipped : MonoBehaviour
{
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("BroColorsEquip") == "Equipped")
        {
            gameObject.GetComponent<Text>().text = "BroColors: Equipped";
        }
        else
         gameObject.GetComponent<Text>().text = "BroColors: Not Equipped";
    }
}
