using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSlowMo : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool On;
    public GameObject canvasGroup;
    public GameObject SlowMoTUT;
    public GameObject SlowmoOutline;
    public GameObject SlowmoBg;
    public GameObject SlowmoBar;
    public GameObject Slowmo_Outline;
    void Start()
    {
        if (PlayerPrefs.GetString("FinalLevel") == "True")
            {
                    //Enable Slow MO
                    canvasGroup.SetActive(true);
                    SlowMoTUT.SetActive(true);
                    SlowmoOutline.SetActive(true);
                    Slowmo_Outline.SetActive(true);
                    SlowmoBar.SetActive(true);
                    SlowmoBg.SetActive(true);
                   On = true;

            }
            else if (PlayerPrefs.GetString("FinalLevel") == "False")
            {
                    //Disable
                     canvasGroup.SetActive(false);
                    SlowMoTUT.SetActive(false);
                    SlowmoOutline.SetActive(false);
                   Slowmo_Outline.SetActive(false);
                    SlowmoBar.SetActive(false);
                    SlowmoBg.SetActive(false);
                    On = false;

            }
    }

    // Update is called once per frame
    void Update()
    {
             if (PlayerPrefs.GetString("FinalLevel") == "True")
            {
                    //Enable Slow MO
                    canvasGroup.SetActive(true);
                    SlowMoTUT.SetActive(true);
                    SlowmoOutline.SetActive(true);
                    Slowmo_Outline.SetActive(true);
                    SlowmoBar.SetActive(true);
                    SlowmoBg.SetActive(true);
                   On = true;

            }
            else if (PlayerPrefs.GetString("FinalLevel") == "False")
            {
                    //Disable
                     canvasGroup.SetActive(false);
                    SlowMoTUT.SetActive(false);
                    SlowmoOutline.SetActive(false);
                   Slowmo_Outline.SetActive(false);
                    SlowmoBar.SetActive(false);
                    SlowmoBg.SetActive(false);
                    On = false;

            }
    }
}
