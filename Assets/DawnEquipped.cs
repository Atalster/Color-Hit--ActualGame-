using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DawnEquipped : MonoBehaviour
{   

    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("DawnEquip") == "Equipped")
        {
            textbox.text = "Dawn: Equipped";
        }
        else {
            textbox.text = "Dawn: Not Equipped";
        }
    }   
}
