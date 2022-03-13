using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerEarned : MonoBehaviour
{

     public float powerEarned;
    public float PowerEarnedDefault;
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
         OverAllPower =  PlayerPrefs.GetFloat("OverallPower");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            PlayerPrefs.SetString("PowerAlreadyEarned", "false");
        }
        if (levelCompleteCheck.LevelDone == true)
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

        PlayerPrefs.SetFloat("powerEarned", powerEarned);
        Powerearned.text = "Power Earned: " + PlayerPrefs.GetFloat("powerEarned").ToString();
        OverAllPower += PlayerPrefs.GetFloat("powerEarned");
        PlayerPrefs.SetFloat("OverallPower", OverAllPower);
        overAllPower.text = "Overall Power: " + PlayerPrefs.GetFloat("OverallPower").ToString();
    }
}


