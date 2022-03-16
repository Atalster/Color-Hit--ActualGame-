using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPEButtons : MonoBehaviour
{       

    public PPEController pPEController;
    public static bool BloomValue = true;
    public static bool CCValue = true;
    public static bool CCModeValue = true;
    public Button bloomButton;
    public Text bloomText;
    public Button CCButton;
    public Text CCText;

    public GameObject CGMode;
    public Button cgMode;
    public Text CgMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (PlayerPrefs.GetString("Bloom") == "On")
             {
                 bloomButton.GetComponent<Image>().color = Color.green;
             bloomText.text = "ON";
             }

               else  if (PlayerPrefs.GetString("Bloom") == "Off")
             {
                    bloomButton.GetComponent<Image>().color = Color.red;
               bloomText.text = "OFF";
             }

             if (PlayerPrefs.GetString("ColorGrading") == "On")
             {
                 CCButton.GetComponent<Image>().color = Color.green;
             CCText.text = "ON";
             cgMode.GetComponent<Button>().interactable = true;

             
             }
        else if (PlayerPrefs.GetString("ColorGrading") == "Off")
        {
            CCButton.GetComponent<Image>().color = Color.red;
             CCText.text = "OFF";
                cgMode.GetComponent<Button>().interactable = false;
        }

        if (PlayerPrefs.GetString("ColorGradingMode") == "On")
        {
            cgMode.GetComponent<Image>().color = Color.green;
            CgMode.text = "ACES";
        }

        else if (PlayerPrefs.GetString("ColorGradingMode") == "Off")
        {
            cgMode.GetComponent<Image>().color = Color.red;
              CgMode.text = "NONE";
        }

    }
    public void BloomButton()
    {
         BloomValue = ! BloomValue;

         if ( BloomValue)
         {
             PlayerPrefs.SetString("Bloom", "On");
            
             
         }
         else if ( BloomValue == false)
         {
              PlayerPrefs.SetString("Bloom", "Off");
          
         }
         

    }

    public void ColorGradingButton()
    {
        CCValue = !CCValue;

        if (CCValue)
        {
            PlayerPrefs.SetString("ColorGrading", "On");
        }

        else if (CCValue == false)
        {
            PlayerPrefs.SetString("ColorGrading", "Off");
        }

    }

    public void CGModeButton()
    {
        CCModeValue = !CCModeValue;

        if (CCModeValue)
        {
            PlayerPrefs.SetString("ColorGradingMode", "On");
        }

        else if (CCModeValue == false)
        {
            PlayerPrefs.SetString("ColorGradingMode", "Off");
        }
    }
}
