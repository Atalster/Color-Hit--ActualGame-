using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SLOWMOTUT : MonoBehaviour
{       
        public Text slowMoTut;
        bool Isdone = false;
        bool isdone = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (PlayerPrefs.GetString("UsedSlowMo") == "true")
        {
            slowMoTut.enabled = false;
        }

        if (PlayerPrefs.GetString("UsedSlowMo") != "true")
        {
            if (Isdone == false)
            {
                slowMoTut.fontSize += 10;
                isdone = false;
                Isdone = true;
                StartCoroutine(SizeDown());
            } 
        }
            

            if (Input.GetKeyDown(KeyCode.Q))
            {
                PlayerPrefs.SetString("UsedSlowMo", "true");
                
            }
    }

    IEnumerator SizeDown()
    {
        Isdone = true;
        if (isdone == false)
        {
            yield return new WaitForSeconds(0.5f);
            slowMoTut.fontSize -= 10;
            yield return new WaitForSeconds(0.5f);
            Isdone = false;
        }
    }
}
