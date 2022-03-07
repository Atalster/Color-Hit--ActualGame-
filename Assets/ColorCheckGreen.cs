using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorCheckGreen : MonoBehaviour
{       
    public bool IsLoading;
    public GameObject ResetRestart;
    public GameObject fakeBallGreen;
    // Start is called before the first frame update

    Vector3 FakeBallPostition;
    Quaternion FakeBallRotation;
    public Transform FakeBallsClones;
     public GameObject HitCheck;
     public GameObject BlueBalls;
     public GameObject RedBalls;
     public GameObject GreenBalls;
     public GameObject YellowBalls;
     bool Isdone;
    // Start is called before the first frame update
    void Start()
    {
        HitCheck.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         
        
    }



        void OnCollisionEnter(Collision col)
    {
     if(col.gameObject.tag == "Green Ball")
     {
         
         
              FakeBallPostition = new Vector3(col.transform.position.x, col.transform.position.y, col.transform.position.z);
         FakeBallRotation = new Quaternion(col.transform.rotation.x, col.transform.rotation.y, col.transform.rotation.z, col.transform.rotation.w);
         StartCoroutine(DestroyBall());
         Instantiate(fakeBallGreen, FakeBallPostition, FakeBallRotation, FakeBallsClones);
         fakeBallGreen.SetActive(true);
        StartCoroutine(Hitcheck());
     }

     else if (col.gameObject.tag == "Blue Ball" || col.gameObject.tag == "Red Ball" || col.gameObject.tag == "Yellow Ball" && IsLoading == false)
     {

         if (ResetRestart.activeInHierarchy)
         {
           Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            IsLoading = true;
            
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
      if(Isdone == false){
      HitCheck.SetActive(false);
      yield return new WaitForSeconds(0.09f);
      HitCheck.SetActive(true);
      }
  }
}
}
