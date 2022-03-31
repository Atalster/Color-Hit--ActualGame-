using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerEarned : MonoBehaviour
{

     public float powerEarned;
    public float PowerEarnedDefault;
     public float PowerEarnedDefault2;
     public float PowerEarnedDefault3;
    public Text Powerearned;
   public bool powerAlreadyEarned;
    public EndLevelStats endLevelStats;
    public float OverAllPower;
    public Text overAllPower;
    bool Isdone;
    public LevelCompleteCheck levelCompleteCheck;
    // Start is called before the first frame update
    void Start()
    {
         PlayerPrefs.GetString("PowerAlreadyEarned");
          PlayerPrefs.GetString("PowerAlreadyEarned2");
           PlayerPrefs.GetString("PowerAlreadyEarned3");
         OverAllPower =  PlayerPrefs.GetFloat("OverallPower");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            PlayerPrefs.SetString("PowerAlreadyEarned", "false");
            PlayerPrefs.SetString("PowerAlreadyEarned2", "false");
             PlayerPrefs.SetString("PowerAlreadyEarned3", "false");
        }

        
        if (levelCompleteCheck.LevelDone == true)
        {
           if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
           {
                          if (Isdone == false){
                if(PlayerPrefs.GetString("PowerAlreadyEarned") == "true")
                {
                    PlayerPrefs.SetFloat("powerEarned", PowerEarnedDefault);
                    Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned").ToString();
                    OverAllPower += PlayerPrefs.GetFloat("powerEarned");
        PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
                    Isdone = true;
                }
           else{
               powerearned();
                Isdone = true;
                PlayerPrefs.SetString("PowerAlreadyEarned", "true");
                PlayerPrefs.Save();
           }
                }
           }

     

              else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
           {
                          if (Isdone == false){
                if(PlayerPrefs.GetString("PowerAlreadyEarned2") == "true")
                {
                    PlayerPrefs.SetFloat("powerEarned2", PowerEarnedDefault2);
                    Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned2").ToString();
                    OverAllPower += PlayerPrefs.GetFloat("powerEarned2");
        PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
                    Isdone = true;
                }
           else{
               powerearned();
                Isdone = true;
                PlayerPrefs.SetString("PowerAlreadyEarned2", "true");
                PlayerPrefs.Save();
           }
                }
           }

                  else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
           {
                          if (Isdone == false){
                if(PlayerPrefs.GetString("PowerAlreadyEarned3") == "true")
                {
                    PlayerPrefs.SetFloat("powerEarned3", PowerEarnedDefault3);
                    Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned3").ToString();
                    OverAllPower += PlayerPrefs.GetFloat("powerEarned3");
        PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
                    Isdone = true;
                }
           else{
               powerearned();
                Isdone = true;
                PlayerPrefs.SetString("PowerAlreadyEarned3", "true");
                PlayerPrefs.Save();
           }
                }
           }

             
        }
    }

    void powerearned()
    {
        if (endLevelStats.score < 110)
        {
            powerEarned += powerEarned;
        }
        else if (endLevelStats.score < 160 && endLevelStats.score > 110)
        {
          powerEarned += 10;
        }

        else if (endLevelStats.score < 190 && endLevelStats.score > 160)
        {
          powerEarned += 25;
        }

        else if (endLevelStats.score < 230 && endLevelStats.score > 190)
        {
          powerEarned += 35;
        }
        else if (endLevelStats.score < 270 && endLevelStats.score > 230)
        {
            powerEarned += 45;
        }

        else if (endLevelStats.score > 270)
        {
           powerEarned += 60;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
 PlayerPrefs.SetFloat("powerEarned", powerEarned);
 Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned").ToString();
  OverAllPower += PlayerPrefs.GetFloat("powerEarned");
  PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
        }

         if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
        {
            PlayerPrefs.SetFloat("powerEarned2", powerEarned);
 Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned2").ToString();
  OverAllPower += PlayerPrefs.GetFloat("powerEarned2");
  PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
        }

         if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
        {
            PlayerPrefs.SetFloat("powerEarned3", powerEarned);
 Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned3").ToString();
  OverAllPower += PlayerPrefs.GetFloat("powerEarned3");
  PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
        }
       
        
        
       
        
    }
}


