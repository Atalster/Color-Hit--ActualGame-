using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorCheckRed : MonoBehaviour
{

   public ColorCheckGreen colorCheckGreen;
   public GameObject ResetRestart;
   public GameObject fakeBallRed;
   public Transform FakeBallsClones;
    // Start is called before the first frame update

    Vector3 FakeBallPostition;
    Quaternion FakeBallRotation;
     public GameObject HitCheck;
      public GameObject BlueBalls;
     public GameObject RedBalls;
     public GameObject GreenBalls;
     public GameObject YellowBalls;
     bool Isdone;
    void Start()
    {
        HitCheck.SetActive(true);
    }
     
     void OnAwake()
     {
         
     }
    // Update is called once per frame
    void Update()
    {
        
    }

       void OnCollisionEnter(Collision col)
    {
     if(col.gameObject.tag == "Red Ball")
     {
         FakeBallPostition = new Vector3(col.transform.position.x, col.transform.position.y, col.transform.position.z);
         FakeBallRotation = new Quaternion(col.transform.rotation.x, col.transform.rotation.y, col.transform.rotation.z, col.transform.rotation.w);
         StartCoroutine(DestroyBall());
         Instantiate(fakeBallRed, FakeBallPostition, FakeBallRotation, FakeBallsClones);
         fakeBallRed.SetActive(true);
         StartCoroutine(Hitcheck());
         
     }
        else if (col.gameObject.tag == "Blue Ball" || col.gameObject.tag == "Yellow Ball" || col.gameObject.tag == "Green Ball" && colorCheckGreen.IsLoading == false)
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


     IEnumerator DestroyBall()
{
   yield return new WaitForSeconds(0.01f);
   Destroy(col.gameObject);
}

  IEnumerator Hitcheck()
  {
        if (BlueBalls.transform.childCount <= 0 && RedBalls.transform.childCount <= 0 && GreenBalls.transform.childCount <= 0 && YellowBalls.transform.childCount <= 0 )
      {
          Isdone = true;
          HitCheck.SetActive(false);

      }
         if (Isdone == false)
      {
      HitCheck.SetActive(false);
      yield return new WaitForSeconds(0.09f);
      HitCheck.SetActive(true);
      }

  }

}


}
