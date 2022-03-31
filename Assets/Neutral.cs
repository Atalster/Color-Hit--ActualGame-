using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neutral : MonoBehaviour
{   

    public GameObject ResetRestart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red Ball" || collision.gameObject.tag == "Yellow Ball"  || collision.gameObject.tag == "Green Ball" || collision.gameObject.tag == "Blue Ball" )
        {
             
                if (ResetRestart.activeInHierarchy)
         {
           Scene scene = SceneManager.GetActiveScene();
           SceneManager.LoadScene(scene.name);
            
            
         }
         else 
         {
             return;

         }
        }
    }
}
