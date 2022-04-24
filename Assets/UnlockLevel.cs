using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{

    public Button[] lvlButtons;
    public GameObject canvasGroup;
    public GameObject SlowMoTUT;
    public GameObject SlowmoOutline;
    public GameObject SlowmoBg;
    public GameObject SlowmoBar;
    public GameObject Slowmo_Outline;
    public Text Dext;
    public Text TextBox;
    public SlowMo slowMo;
    public static bool On;

   
    // Start is called before the first frame update
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

       



      

       int levelAt = PlayerPrefs.GetInt("levelAt", 0);

       for (int i = 0; i < lvlButtons.Length; i++)
       {
           
         
           if (i > levelAt)
           {
               lvlButtons[i].interactable = false;

               if (lvlButtons[i].interactable == false)
               {
                   Color col = lvlButtons[i].GetComponent<Image>().color;
                    col.a = 0;
                    lvlButtons[i].GetComponent<Image>().color = col;
               }
           }
       }
    }

    // Update is called once per frame
    void Update()
    {
             if (Input.GetKeyDown(KeyCode.I))
            {
                PlayerPrefs.SetString("FinalLevel", "True");

            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                PlayerPrefs.SetString("FinalLevel", "False");

            }

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
