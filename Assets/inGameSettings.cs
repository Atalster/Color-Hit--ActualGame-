using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class inGameSettings : MonoBehaviour
{   
    public Animator backgroundAnimator;
    public Animator ForegoundAnimator; 
    public GameObject background;
    public Button mainMenu;
    public Button closeGame;
    public GameObject ingameSettings;
    bool Opened;
    string currentState;
    bool Isdone;
    bool isdone;
    public CharacterController characterController;

 
    // Start is called before the first frame update
    void Start()
    {
        ingameSettings.SetActive(false);

    }

        void ChangeAnimationState(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
       backgroundAnimator.Play(newState);

        //Reassign the current state
        currentState = newState;
}

        void ChangeAnimationState1(string newState)
{
    //stops the same animation from interrupting itself
        if (currentState == newState) return;

        //Play new animation
       ForegoundAnimator.Play(newState);

        //Reassign the current state
        currentState = newState;
}

    // Update is called once per frame
    void Update()
    {
        //Open In Game Settings
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Opened = !Opened;

        }

                 if (Opened)
       {
           if(Isdone == false)
           {
               isdone = false;
               
               characterController.enabled = false;
                 Invoke("ButtonsON", 0.3f);
           ingameSettings.SetActive(true);
           ChangeAnimationState("Open");
           ChangeAnimationState1("ForegroundOpen");
           Isdone = true;
           }
         
       }

       else if (Opened == false)
       {
           if (isdone == false)
           {
               Isdone = false;
               
               characterController.enabled = true;
               mainMenu.gameObject.SetActive(false);
        closeGame.gameObject.SetActive(false);
                Invoke("ButtonsOFF", 0.3f);
                
          ChangeAnimationState("Close");
          ChangeAnimationState1("ForegroundClose");
          isdone = true;
           }
         
          
           
       }

            if (Opened && Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("MainMenu");
            }

               if (Opened && Input.GetKeyDown(KeyCode.LeftShift))
            {
                Application.Quit();
            }
    
    }
    void ButtonsON()
    {
        mainMenu.gameObject.SetActive(true);
        closeGame.gameObject.SetActive(true);
        
    }

    void ButtonsOFF()
    {
        
        ingameSettings.SetActive(false);
    }
}
