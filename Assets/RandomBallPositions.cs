using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    Collider m_collider;
    Vector3 point;
    bool Isdone;
    

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
    }
}