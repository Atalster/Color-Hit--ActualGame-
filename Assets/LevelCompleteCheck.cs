using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompleteCheck : MonoBehaviour
{
    public GameObject BlueBalls;
      public GameObject RedBalls;
        public GameObject GreenBalls;
          public GameObject YellowBalls;
          bool Isdone;
          
          public bool LevelDone;
          public CharacterController cc;
          public int childCount;
          public int childCountRed;
          public int childCountGreen;
         public int childCountYellow;
        
         bool isdone;
        
        
          
          
     GameObject Bluechild;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
          if (LevelDone == true && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (LevelDone)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        if (Isdone == false) {
       Blueballs();

        Redballs();
       
       Greenballs();
      
      Yellowballs();

     
       Debug.Log(Blueballs() + " " + Redballs() + " " + Greenballs() + " " + Yellowballs());
        }
      
       if (Blueballs() + Redballs() + Greenballs() + Yellowballs() == 0)
       {
           Debug.Log("Game Over!");
           Isdone = true;
           
           LevelDone = true;

           
           cc.enabled = false;
        

       }

      
       

       



    }

  

     int Blueballs()
    {
        
        for (childCount = 0; childCount < BlueBalls.transform.childCount; childCount++)
        {
           

          
        }
        
        return childCount;

    }

      int Redballs()
    {
        
        for (childCountRed = 0; childCountRed < RedBalls.transform.childCount; childCountRed++)
        {
           

          
        }
        
        return childCountRed;

    }

        int Greenballs()
    {
        
        for (childCountGreen = 0; childCountGreen < GreenBalls.transform.childCount; childCountGreen++)
        {
           

          
        }
        
        return childCountGreen;

    }

         int Yellowballs()
    {
        
        for (childCountYellow = 0; childCountYellow < YellowBalls.transform.childCount; childCountYellow++)
        {
           

          
        }
        
        return childCountYellow;

    }

}
