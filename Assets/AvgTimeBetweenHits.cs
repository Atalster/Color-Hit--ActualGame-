using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvgTimeBetweenHits : MonoBehaviour
{

    bool Isdone;
    bool isdone;
    public double AvgTime;
     public double Stall;
    public GameObject HitCheck;
    public Transform AvgTimeClones;
    // Start is called before the first frame update
    void Start()
    {
         AvgTime = 0;
    }
    void OnAwake()
    {
        AvgTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Isdone == false)
        {
            AvgTime += Time.deltaTime;

        }

        
      
   if(HitCheck.activeInHierarchy == false)
        {
            Avgtime();
            Isdone = true;
            if (isdone == false){
            Invoke("Instantiate", 0.1f);
            isdone = true;
            
            }
            
         

    }
    }

    double Avgtime()
    {
        return AvgTime;
          
        }
        
        
    

    void Instantiate()
    {
        Instantiate(gameObject, gameObject.transform.position, gameObject.transform.rotation,AvgTimeClones );

    }
}

