using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomBallPositions : MonoBehaviour
{
    public GameObject BlueBalls;
    public GameObject RedBalls;
    public GameObject GreenBalls;
    public GameObject YellowBalls;
    public GameObject StartingBall;
    public GameObject startingColliderCheck;
    public GameObject BallsGuard;
     public GameObject Balls1Guard;
      public GameObject Balls2Guard;
       public GameObject Balls3Guard;
        public GameObject Balls4Guard;
         public GameObject Balls5Guard;

         public GameObject Z1;
         public GameObject Z2;
           public GameObject X1;
             public GameObject X2;
               public GameObject Y1;
                 public GameObject Y2;
                 public GameObject X3;
                 public GameObject X4;

    Collider m_collider;
    Vector3 point;
    bool Isdone;
    

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
               for (int i = 0; i <= 4; i++)
            {
                var position = new Vector3(Random.Range(-4.9f, -11.9f), Random.Range(0.7f, 3.5f), Random.Range(0.2f, -12f));
           
                
                
                        GameObject firstInstance = Instantiate(StartingBall, position, Quaternion.identity);
              

                

                float BallColor =  Random.Range(1, 4 + 1);
                if (BallColor == 1 )
                {
                    firstInstance.transform.parent = BlueBalls.transform;
                    firstInstance.tag = "Blue Ball";
                }
               
                   if (BallColor == 2 )
                {
                    firstInstance.transform.parent = RedBalls.transform;
                    firstInstance.tag = "Red Ball";
                }
               
                   if (BallColor == 3 )
                {
                    firstInstance.transform.parent = GreenBalls.transform;
                    firstInstance.tag = "Green Ball";
                }
               
                   if (BallColor == 4 )
                {
                    firstInstance.transform.parent = YellowBalls.transform;
                    firstInstance.tag = "Yellow Ball";
                }
              
            }
        }


      else  if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level02"))
        {
               for (int i = 0; i <= 6; i++)
            {
                var position = new Vector3(Random.Range(-30f, -11.9f), Random.Range(1.3f, 3.5f), Random.Range(0.2f, -12f));
           
                
                
                        GameObject firstInstance = Instantiate(StartingBall, position, Quaternion.identity);
              

                

                float BallColor =  Random.Range(1, 4 + 1);
                if (BallColor == 1 )
                {
                    firstInstance.transform.parent = BlueBalls.transform;
                    firstInstance.tag = "Blue Ball";
                }
               
                   if (BallColor == 2 )
                {
                    firstInstance.transform.parent = RedBalls.transform;
                    firstInstance.tag = "Red Ball";
                }
               
                   if (BallColor == 3 )
                {
                    firstInstance.transform.parent = GreenBalls.transform;
                    firstInstance.tag = "Green Ball";
                }
               
                   if (BallColor == 4 )
                {
                    firstInstance.transform.parent = YellowBalls.transform;
                    firstInstance.tag = "Yellow Ball";
                }
              
            }
        }

              else  if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level03"))
        {
               for (int i = 0; i <= 4; i++)
            {
                var position = new Vector3(Random.Range(X1.transform.position.x, X2.transform.position.x), Random.Range(Y1.transform.position.y, Y2.transform.position.y), Random.Range(Z1.transform.position.z, Z2.transform.position.z));
           
                
                
                        GameObject firstInstance = Instantiate(StartingBall, position, Quaternion.identity);
              

                

                float BallColor =  Random.Range(1, 4 + 1);
                if (BallColor == 1 )
                {
                    firstInstance.transform.parent = BlueBalls.transform;
                    firstInstance.tag = "Blue Ball";
                }
               
                   if (BallColor == 2 )
                {
                    firstInstance.transform.parent = RedBalls.transform;
                    firstInstance.tag = "Red Ball";
                }
               
                   if (BallColor == 3 )
                {
                    firstInstance.transform.parent = GreenBalls.transform;
                    firstInstance.tag = "Green Ball";
                }
               
                   if (BallColor == 4 )
                {
                    firstInstance.transform.parent = YellowBalls.transform;
                    firstInstance.tag = "Yellow Ball";
                }
              
            }

               for (int i = 0; i <= 4; i++)
            {
                var position = new Vector3(Random.Range(X3.transform.position.x, X4.transform.position.x), Random.Range(Y1.transform.position.y, Y2.transform.position.y), Random.Range(Z1.transform.position.z, Z2.transform.position.z));
           
                
                
                        GameObject firstInstance = Instantiate(StartingBall, position, Quaternion.identity);
              

                

                float BallColor =  Random.Range(1, 4 + 1);
                if (BallColor == 1 )
                {
                    firstInstance.transform.parent = BlueBalls.transform;
                    firstInstance.tag = "Blue Ball";
                }
               
                   if (BallColor == 2 )
                {
                    firstInstance.transform.parent = RedBalls.transform;
                    firstInstance.tag = "Red Ball";
                }
               
                   if (BallColor == 3 )
                {
                    firstInstance.transform.parent = GreenBalls.transform;
                    firstInstance.tag = "Green Ball";
                }
               
                   if (BallColor == 4 )
                {
                    firstInstance.transform.parent = YellowBalls.transform;
                    firstInstance.tag = "Yellow Ball";
                }
              
            }
        }
         


    }

    // Update is called once per frame
    void Update()
    {
    }
}