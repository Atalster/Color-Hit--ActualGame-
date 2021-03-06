using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevelStats : MonoBehaviour
{
    public Text time;
    
    public Text BestTime;
    public Text Score;
    public float score;
    public Animator ScorePanelanimator;
    public Animator MiddlePanel;
    public LevelSelect levelSelect;
    
    public Text PowerLost;
    public Text AvgTimeBetweenHits;
    public LevelCompleteCheck levelCompleteCheck;
    public Timer timer;
    public Transform AvgTimeclones;
    public double avgTimeBetweenHits = 0;
    double L;
    bool isDone;
     bool IsDone;
     bool ScoreCalculated;
     bool FirstEndTime;
     bool firstEndTimedouble;
     double EndTimeElse;
    float bestTime;
     string currentState;
     public PowerEarned powerEarned;
   public int nextSceneLoad;
   
    
    
     

    // Start is called before the first frame update
    void Start()
    {
      
       nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.GetString("FinalLevel", "False");
    }
    void ChangeAnimationState(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
        ScorePanelanimator.Play(newState);

        //Reassign the current state
        currentState = newState;
}

   void ChangeAnimationState1(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
       MiddlePanel.Play(newState);

        //Reassign the current state
        currentState = newState;
}
    // Update is called once per frame
    void Update()
    {
        //Turn Interactble Buttons off

        




        int children = AvgTimeclones.transform.childCount;
        if (levelCompleteCheck.LevelDone == true)
        {

          if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
          {
             //Calulating and displaying the time it took to finish level(EndTime)

             if  (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
             {
               PlayerPrefs.SetInt("levelAt", nextSceneLoad);
             }
        double EndTime = timer.TimeStartedWith - timer.TimeLeft;

          if (EndTime <= 12)
            {
              time.GetComponent<Text>().color = Color.green;
              
            }

              else if ( EndTime <= 20 && EndTime > 12)
            {
               time.GetComponent<Text>().color = Color.yellow;
            }

              else if (EndTime <= 30 && EndTime > 20)
            {
               time.GetComponent<Text>().color = Color.red;
            }
            
            time.text = "TIME: " + EndTime.ToString("00.00") + "/s";
        

                //Best Time Calculations
                if (powerEarned.OverAllPower == 0)
                {
                  PlayerPrefs.SetFloat("bestTime", (float)EndTime);
                  
                }



          if (EndTime < PlayerPrefs.GetFloat("bestTime"))
          {
            PlayerPrefs.SetFloat("bestTime", (float)EndTime);
            
          }
          else 
          {
            PlayerPrefs.GetFloat("bestTime");
          }
     
          BestTime.text = "Best Time: " + PlayerPrefs.GetFloat("bestTime").ToString("00.00");
          }

         
         


  if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
          {
            
             //Calulating and displaying the time it took to finish level(EndTime)
              if  (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
             {
               PlayerPrefs.SetInt("levelAt", nextSceneLoad);
             }
        double EndTime = timer.TimeStartedWith - timer.TimeLeft;

          if (EndTime <= 12)
            {
              time.GetComponent<Text>().color = Color.green;
              
            }

              else if ( EndTime <= 20 && EndTime > 12)
            {
               time.GetComponent<Text>().color = Color.yellow;
            }

              else if (EndTime <= 30 && EndTime > 20)
            {
               time.GetComponent<Text>().color = Color.red;
            }
            
            time.text = "TIME: " + EndTime.ToString("00.00") + "/s";
        

                //Best Time Calculations
                if (PlayerPrefs.GetString("FirstBestTime2") != "true")
                {
                  PlayerPrefs.SetFloat("bestTime2", (float)EndTime);
                  
                }



          if (EndTime < PlayerPrefs.GetFloat("bestTime2"))
          {
            PlayerPrefs.SetFloat("bestTime2", (float)EndTime);
            
          }
          else 
          {
            PlayerPrefs.GetFloat("bestTime2");
          }
     
          BestTime.text = "Best Time: " + PlayerPrefs.GetFloat("bestTime2").ToString("00.00");

          LevelSelect.Clicks02 += 1f;
          PlayerPrefs.SetString("FirstBestTime", "true");
          }
            //LEVEL 3
           if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
          {
            
             //Calulating and displaying the time it took to finish level(EndTime)
             PlayerPrefs.SetString("FinalLevel", "True");  
              if  (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
             {
               PlayerPrefs.SetInt("levelAt", nextSceneLoad);
             }
        double EndTime = timer.TimeStartedWith - timer.TimeLeft;

          if (EndTime <= 29)
            {
              time.GetComponent<Text>().color = Color.green;
              
            }

              else if ( EndTime <= 45 && EndTime > 29)
            {
               time.GetComponent<Text>().color = Color.yellow;
            }

              else if (EndTime <= 60 && EndTime > 45)
            {
               time.GetComponent<Text>().color = Color.red;
            }
            
            time.text = "TIME: " + EndTime.ToString("00.00") + "/s";
        

                //Best Time Calculations
                if (PlayerPrefs.GetString("FirstBestTime3") != "true")
                {
                  PlayerPrefs.SetFloat("bestTime3", (float)EndTime);
                  
                }



          if (EndTime < PlayerPrefs.GetFloat("bestTime3"))
          {
            PlayerPrefs.SetFloat("bestTime3", (float)EndTime);
            
          }
          else 
          {
            PlayerPrefs.GetFloat("bestTime3");
          }
     
          BestTime.text = "Best Time: " + PlayerPrefs.GetFloat("bestTime3").ToString("00.00");

          LevelSelect.Clicks02 += 1f;
          PlayerPrefs.SetString("FirstBestTime3", "true");
          }



                //Calculating AvgTimeBetweenHits

              //Grab all avg time from child objects and add it to one variable
             if (isDone == false) {
            foreach (Transform child in AvgTimeclones.transform)
           {
              avgTimeBetweenHits += AvgTimeclones.transform.GetComponentInChildren<AvgTimeBetweenHits>(child).AvgTime;
              
           }
           isDone =  true;
             }

          //Grab the variable and calculate the Mean (average) 
          //Then put variable in text box
           if (IsDone == false && isDone == true)
             {
                avgTimeBetweenHits /= AvgTimeclones.transform.childCount;
                AvgTimeBetweenHits.text = "Avg. Time Between Hits: " +  avgTimeBetweenHits.ToString("00.00") + "/s";
                IsDone = true;
             }


      //Score System next
      if(ScoreCalculated == false) {
       score += ((float)avgTimeBetweenHits) * 5f;
       score += ((float)timer.TimeLeft) * 11f;
      Mathf.Round(score);

       ScoreCalculated = true;
       
       Invoke("ScoreText", 1.15f);
      }

      //Power Earned
      
     

     
       
        }
       

             }
      
      void ScoreText()
      {
        Score.text = "SCORE: " + score.ToString("00");
       
      }

    }


     

             

           
     

