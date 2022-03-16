using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{   
        
            [SerializeField]
    private GameObject playerCam;

   
    // Start is called before the first frame update
    void Start()
    {
        playerCam.GetComponent<Camera>().fieldOfView = PlayerPrefs.GetFloat("NewFov");
    }

      void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
