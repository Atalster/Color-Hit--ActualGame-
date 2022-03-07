using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public double TimeLeft = 20f;
    public double TimeStartedWith = 20f;
    public GameObject ResetRestart;
    public LevelCompleteCheck levelCompleteCheck;
    bool Isdone;
    public GameObject LevelCompletedUI;
    string currentState;
    public Animator MiddleBarEndLevelUI;
    public Animator TopBarEndLevelUI;
    public Animator BottomBarEndLevelUI;
    public Animator ScorePanelanimator;
    public Animator MiddlePanel;
    public GameObject ScorePanel;
    public GameObject middlePanel;
     public GameObject middlePanel2;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = TimeLeft.ToString("00.00");
         LevelCompletedUI.SetActive(false);
          ScorePanel.SetActive(false);
        middlePanel.SetActive(false);
    }
void ChangeAnimationState(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
        MiddleBarEndLevelUI.Play(newState);

        //Reassign the current state
        currentState = newState;
}
void ChangeAnimationState1(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
        TopBarEndLevelUI.Play(newState);

        //Reassign the current state
        currentState = newState;
}
void ChangeAnimationState2(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
        BottomBarEndLevelUI.Play(newState);

        //Reassign the current state
        currentState = newState;
}
    void ChangeAnimationState3(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
        ScorePanelanimator.Play(newState);

        //Reassign the current state
        currentState = newState;
}

   void ChangeAnimationState4(string newState)
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
        if (Isdone == false) {
        TimeLeft -= Time.deltaTime;

        timer.text = TimeLeft.ToString("00.00");

        if (TimeLeft <= 0)
        {
            if (ResetRestart.activeInHierarchy)
            {
                Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            }
            else 
            return;
        }
        }

        if (levelCompleteCheck.LevelDone == true)
        {
            Isdone = true;
                ChangeAnimationState("MiddleBarEndLevel");
            ChangeAnimationState1("TopBarEndLevel");
            ChangeAnimationState2("BottomBarEndLevel");
            Invoke("Panels", 1.15f);
            LevelCompletedUI.SetActive(true);
        

        }
     }
    public void Panels()
    {
         ChangeAnimationState3("PanelYellowEndLevel");
       ChangeAnimationState4("PanelEndLevel");
       ScorePanel.SetActive(true);
        middlePanel.SetActive(true);

    }
}
