using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float InfiniteMoney = PlayerPrefs.GetFloat("OverallPower") + 500;
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerPrefs.SetFloat("OverallPower", InfiniteMoney);
        }
    }
}
