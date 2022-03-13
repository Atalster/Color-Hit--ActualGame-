using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardModeEquipped : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (PlayerPrefs.GetString("HardModeEquip") == "Equipped")
            {
                gameObject.GetComponent<Text>().text = " Hard Mode: Equipped";
            
            }
            else
            {
                 gameObject.GetComponent<Text>().text = "Hard Mode: Not Equipped";
            }
    }
}
