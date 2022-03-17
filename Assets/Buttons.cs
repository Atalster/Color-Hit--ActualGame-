using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


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
    public GameObject ThemeCheck;
    public GameObject Settingcheck;
    public GameObject howtoplaycheck;
    public Animator Howtoplayanimator;
    public GameObject HowtoplayTexts;
    public GameObject Levelstexts;
    public PowerEarned powerEarned;
    public Animator InsufficentPower;
    public GameObject Themes;
    public Text Buyinsufficent;
    public Overallpower overallpower;
    public GameObject ThemesCheck;
    public GameObject Equip;
    public GameObject Equip2;
    public GameObject Equip3;
      public GameObject Equip4;
     
    public GameObject Buy;
    public GameObject Buy2;
    public GameObject Buy3;
    public GameObject Buy4;

    public MouseLook mouseLook;
    public static float NewSens;
    public Animator Arrowsanimator1;
    public Animator Arrowsanimator2;
    public GameObject Arrow1;
    public GameObject Arrow2;
    bool IsDone;
   
    

    float[] costs = {250, 300, 450, 500};
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
        ThemesCheck.SetActive(false);
          Themes.SetActive(false);
        Equip.SetActive(false);
        Equip2.SetActive(false);
        Buy2.SetActive(true);
        Buy.SetActive(true);
        Equip3.SetActive(false);
        Buy3.SetActive(true);
        Equip4.SetActive(false);
        Buy4.SetActive(true);
        PlayerPrefs.GetString("SettingsArrows");
    }

      void Awake()
      {
        DontDestroyOnLoad(this);
      }
    // Update is called once per frame
    void Update()
    { 
        if (IsDone == false)
        {
            if (PlayerPrefs.GetString("SettingsArrows") != "Off")
            {
                Arrow1.SetActive(true);
          Arrow2.SetActive(true);
              Arrowsanimator1.Play("SettingArrows");
              Arrowsanimator2.Play("SettingArrows");
            }
            
        }

        if (PlayerPrefs.GetString("SettingsArrows") == "Off")
        {
          Arrow1.SetActive(false);
          Arrow2.SetActive(false);
        }
      
     


        if (MainMenuCheck.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("OverallPower", 0);
        }
        if(ThemeCheck.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            Themes.SetActive(false);
            ThemesCheck.SetActive(false);
            MainMenuCheck.SetActive(true);
        }

          //Reset HardMOde Equipped
          if(Input.GetKeyDown(KeyCode.H))
          {
            PlayerPrefs.SetString("HardModeEquip", "NotEquipped");
          }

            if(Input.GetKeyDown(KeyCode.H))
          {
            PlayerPrefs.SetString("SunsetEquip", "NotEquipped");
          }

        //Check if Themes are bought

        if (PlayerPrefs.GetString("BroColors") == "Bought")
        {
           Equip.SetActive(true);
        Buy.SetActive(false);

        }
         if (PlayerPrefs.GetString("HardMode") == "Bought")
        {
           Equip2.SetActive(true);
        Buy2.SetActive(false);

        }

        if (PlayerPrefs.GetString("Sunset") == "Bought")
        {
          Equip3.SetActive(true);
        Buy3.SetActive(false);
        }

         if (PlayerPrefs.GetString("Dawn") == "Bought")
        {
          Equip4.SetActive(true);
        Buy4.SetActive(false);
        }


        //Check iF Themes are eqipped
        if (PlayerPrefs.GetString("BroColorsEquip") == "Equipped")
        {
          
          Equip.GetComponentInChildren<Text>().text = "Unequip";
        }

          else if (PlayerPrefs.GetString("HardModeEquip") == "Equipped")
        {
          
          Equip2.GetComponentInChildren<Text>().text = "Unequip";
        }

        else if (PlayerPrefs.GetString("SunsetEquip") == "Equipped")
        {
          Equip3.GetComponentInChildren<Text>().text = "Unequip";
        }

          else if (PlayerPrefs.GetString("DawnEquip") == "Equipped")
        {
          Equip4.GetComponentInChildren<Text>().text = "Unequip";
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

    
    public void ThemesClick()
    {
            Themes.SetActive(true);
            ThemesCheck.SetActive(true);
            MainMenuCheck.SetActive(false);
    }
    void PanelsClose()
    {
        
        SettingsBackground.SetActive(false);
        HowToPlayBackground.SetActive(false);
        Levels.SetActive(false);
    }
    
    public void OnSettingsButtonClick()
    {
      PlayerPrefs.SetString("SettingsArrows", "Off");
      
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
           Levelstexts.SetActive(true);
    }

    public void OnBackClick()
    {

 if (howtoplaycheck.activeInHierarchy == true)
        {
            
       HowtoplayTexts.SetActive(false);
        howtoplaycheck.SetActive(false);
        Howtoplayanimator.Play("Howtoplayclose");
       Invoke("PanelsClose", 0.3f);
        
        
        }
          if (Settingcheck.activeInHierarchy == true )
        {
           
        SettingsTexts.SetActive(false);
       Settingcheck.SetActive(false);
       SettingsPanelanimator.Play("SettingspanelClose");
       Invoke("PanelsClose", 0.3f);
        
        }
          if (playCheck.activeInHierarchy == true)
        {
            
        Levelstexts.SetActive(false);
        playCheck.SetActive(false);
        LevelsPanels.Play("Levelspanelclose");
        Invoke("PanelsClose", 0.45f);
       
        }
    }

    public void Buy1Click()
    {
    
        float Remaining = PlayerPrefs.GetFloat("OverallPower") - costs[0];
        if(PlayerPrefs.GetFloat("OverallPower") >= costs[0])
        {
             PlayerPrefs.SetString("BroColors", "Bought");
             Buyinsufficent.text = "Bought!";
               InsufficentPower.Play("Fadeinout");
               PlayerPrefs.SetFloat("OverallPower", Remaining);
                Equip.SetActive(true);
                Buy.SetActive(false);
          
        }   
        else
        InsufficentPower.Play("Fadeinout");
       

    }
     public void Buy2Click()
    {
      float Remaining = PlayerPrefs.GetFloat("OverallPower") - costs[1];
      if (PlayerPrefs.GetFloat("OverallPower") >= costs[1])
      {
        PlayerPrefs.SetString("HardMode", "Bought");
        Buyinsufficent.text = "Bought!";
        InsufficentPower.Play("Fadeinout");
        PlayerPrefs.SetFloat("OverallPower", Remaining);
        Equip2.SetActive(true);
        Buy2.SetActive(false);
      }
        else
        InsufficentPower.Play("Fadeinout");
     
    }
     public void Buy3Click()
    {
     float Remaining = PlayerPrefs.GetFloat("OverallPower") - costs[2];

        if (PlayerPrefs.GetFloat("OverallPower") >= costs[2])
      {
        PlayerPrefs.SetString("Sunset", "Bought");
        Buyinsufficent.text = "Bought!";
        InsufficentPower.Play("Fadeinout");
        PlayerPrefs.SetFloat("OverallPower", Remaining);
        Equip3.SetActive(true);
        Buy3.SetActive(false);
      }
        else
        InsufficentPower.Play("Fadeinout");
     
    }
    
     public void Buy4Click()
    {
     float Remaining = PlayerPrefs.GetFloat("OverallPower") - costs[3];

        if (PlayerPrefs.GetFloat("OverallPower") >= costs[3])
      {
        PlayerPrefs.SetString("Dawn", "Bought");
        Buyinsufficent.text = "Bought!";
        InsufficentPower.Play("Fadeinout");
        PlayerPrefs.SetFloat("OverallPower", Remaining);
        Equip4.SetActive(true);
        Buy4.SetActive(false);
      }
        else
        InsufficentPower.Play("Fadeinout");
    }

    public void Equip1Click()
    {   
         if (PlayerPrefs.GetString("HardModeEquip") == "Equipped" || PlayerPrefs.GetString("SunsetEquip") == "Equipped" || PlayerPrefs.GetString("DawnEquip") == "Equipped" )
        {
          Buyinsufficent.text = "Unequip First!";
        InsufficentPower.Play("Fadeinout");
        return;
        }
        else{

               //Unequip Themes
         if (PlayerPrefs.GetString("BroColorsEquip") == "Equipped" )
        {
            Equip.GetComponentInChildren<Text>().text = "Equip";
            PlayerPrefs.SetString("BroColorsEquip", "NotEquipped");
           return;
        }
      else if (PlayerPrefs.GetString("BroColorsEquip") != "Equipped") {
         Equip.GetComponentInChildren<Text>().text = "Equipped";
        PlayerPrefs.SetString("BroColorsEquip", "Equipped");

      }
       
        }


       
       
    }
      public void Equip2Click()
    {
        if (PlayerPrefs.GetString("BroColorsEquip") == "Equipped" || PlayerPrefs.GetString("SunsetEquip") == "Equipped" || PlayerPrefs.GetString("DawnEquip") == "Equipped" )
        {
          Buyinsufficent.text = "Unequip First!";
        InsufficentPower.Play("Fadeinout");
        return;
        }
        else {
             if (PlayerPrefs.GetString("HardModeEquip") == "Equipped" )
        {
            Equip2.GetComponentInChildren<Text>().text = "Equip";
            PlayerPrefs.SetString("HardModeEquip", "NotEquipped");
           return;
        }
        else if (PlayerPrefs.GetString("HardModeEquip") != "Equipped"){

              Equip2.GetComponentInChildren<Text>().text = "Unequip";
        PlayerPrefs.SetString("HardModeEquip", "Equipped");
        }
      

        }
 
       
      
    }
      public void Equip3Click()
    {
             if (PlayerPrefs.GetString("HardModeEquip") == "Equipped" || PlayerPrefs.GetString("BroColorsEquip") == "Equipped" || PlayerPrefs.GetString("DawnEquip") == "Equipped" )
        {
          Buyinsufficent.text = "Unequip First!";
        InsufficentPower.Play("Fadeinout");
        return;
        }

        else{

               //Unequip Themes
         if (PlayerPrefs.GetString("SunsetEquip") == "Equipped" )
        {
            Equip3.GetComponentInChildren<Text>().text = "Equip";
            PlayerPrefs.SetString("SunsetEquip", "NotEquipped");
           return;
        }
      else if (PlayerPrefs.GetString("SunsetEquip") != "Equipped"){
         Equip3.GetComponentInChildren<Text>().text = "Unequip";
        PlayerPrefs.SetString("SunsetEquip", "Equipped");

      }
       
        }
      
    }
      public void Equip4Click()
    {
      
           if (PlayerPrefs.GetString("HardModeEquip") == "Equipped" || PlayerPrefs.GetString("BroColorsEquip") == "Equipped" || PlayerPrefs.GetString("SunsetEquip") == "Equipped" )
        {
          Buyinsufficent.text = "Unequip First!";
        InsufficentPower.Play("Fadeinout");
        return;
        }
        else{

               //Unequip Themes
         if (PlayerPrefs.GetString("DawnEquip") == "Equipped" )
        {
            Equip4.GetComponentInChildren<Text>().text = "Equip";
            PlayerPrefs.SetString("DawnEquip", "NotEquipped");
           return;
        }
      else if (PlayerPrefs.GetString("DawnEquip") != "Equipped") {
         Equip4.GetComponentInChildren<Text>().text = "Unequip";
        PlayerPrefs.SetString("DawnEquip", "Equipped");

      }
       
        }

      
    }

    

    
}
