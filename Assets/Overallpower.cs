using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overallpower : MonoBehaviour
{

        
        public float OverAllPower;
        public Text power;
    // Start is called before the first frame update
    void Start()
    {
          OverAllPower = PlayerPrefs.GetFloat("OverallPower");
    }

    // Update is called once per frame
    void Update()
    {
        OverAllPower = PlayerPrefs.GetFloat("OverallPower");
        power.text = "Power: " + PlayerPrefs.GetFloat("OverallPower").ToString("00");
    }
}
