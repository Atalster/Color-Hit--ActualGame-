using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Animator SettingsPanelanimator;
    public GameObject SettingsBackground;
    public GameObject SettingsTexts;
    public Animator SettingsBaranimator;
    public GameObject HowToPlayBackground;
    public GameObject HowToPlaytexts;
    public GameObject Levels;
    public Animator LevelsPanels;
    public GameObject MainMenuCheck;
    public GameObject playCheck;
    public GameObject Settingcheck;
    public GameObject howtoplaycheck;
    public Animator Howtoplayanimator;
    public GameObject HowtoplayTexts;
    public GameObject Levelstexts;
    // Start is called before the first frame update
    void Start()
    {
        SettingsBackground.SetActive(false);
        SettingsTexts.SetActive(false);
        HowToPlaytexts.SetActive(false);
        Levels.SetActive(false);
        howtoplaycheck.SetActive(false);
        Settingcheck.SetActive(false);
        playCheck.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenuCheck.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (howtoplaycheck.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            
       HowtoplayTexts.SetActive(false);
        howtoplaycheck.SetActive(false);
        Howtoplayanimator.Play("Howtoplayclose");
       Invoke("PanelsClose", 0.3f);
        
        
        }
          if (Settingcheck.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
           
        SettingsTexts.SetActive(false);
       Settingcheck.SetActive(false);
       SettingsPanelanimator.Play("SettingspanelClose");
       Invoke("PanelsClose", 0.3f);
        
        }
          if (playCheck.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            
        Levelstexts.SetActive(false);
        playCheck.SetActive(false);
        LevelsPanels.Play("Levelspanelclose");
        Invoke("PanelsClose", 0.45f);
       
        }
    }
    void PanelsClose()
    {
        
        SettingsBackground.SetActive(false);
        HowToPlayBackground.SetActive(false);
        Levels.SetActive(false);
    }
    
    public void OnSettingsButtonClick()
    {
        SettingsBackground.SetActive(true);
        Invoke("SettingTexts", 0.45f);
        SettingsPanelanimator.Play("SettingsPanelAnimation");
        MainMenuCheck.SetActive(false);
        Settingcheck.SetActive(true);
    }

    void SettingTexts()
    {
        SettingsTexts.SetActive(true);
        SettingsBaranimator.Play("Settingsbaropen");
    }

    public void OnHowToPlayButtonClick()
    {
         HowToPlayBackground.SetActive(true);
       Invoke("HowToPlayTexts", 0.45f);
        Howtoplayanimator.Play("HowToPLayOpen");
     MainMenuCheck.SetActive(false);
    
     howtoplaycheck.SetActive(true);
    }
      void HowToPlayTexts()
    {
        HowToPlaytexts.SetActive(true);
        SettingsBaranimator.Play("Settingsbaropen");
    }

   public void OnPlayButtonClick()
    {
        Levels.SetActive(true);
        LevelsPanels.Play("LevelsPanel");
         MainMenuCheck.SetActive(false);
          playCheck.SetActive(true);
    }
}
