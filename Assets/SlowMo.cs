using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlowMo : MonoBehaviour
{
 public float SlowDownFactor = 0.05f;
 public float slowMotionAbilityTime = 10f;
 public float maxSlowMotionAbilityTime = 10f;
 private float startTimeScale;
 private float startFixedDeltaTime;
 
 public Movement movement;
 public MouseLook mouseLook;
  float startMouseSens;
  float FOV;
  bool minusAbilityTime;
  bool addAbilityTime;
 public bool isUsing;
  public bool isNotUsing;
  private float FieldOfview;
  public GameObject resetRestart;
  public GameObject playerCam;
  public Image SlowMoOverlay;


void Start()
{
  startTimeScale = Time.timeScale;
     startFixedDeltaTime = Time.fixedDeltaTime;
    startMouseSens = PlayerPrefs.GetFloat("NewSens");
    FOV = PlayerPrefs.GetFloat("NewFov");
    isUsing = false;
      movement.speed = 7f;
     MouseLook.mouseSensitivity = PlayerPrefs.GetFloat("NewSens");
     minusAbilityTime = false;
     addAbilityTime = true;
     
    FieldOfview = playerCam.GetComponent<Camera>().fieldOfView;

}
 void Update()
 {
     if (isUsing)
     {
         float NewFov = FOV - 20;
         playerCam.GetComponent<Camera>().fieldOfView -= Time.unscaledDeltaTime * 70;
     playerCam.GetComponent<Camera>().fieldOfView  =  Mathf.Clamp( playerCam.GetComponent<Camera>().fieldOfView , NewFov, FOV);
     }

     if (isUsing == false)
     {
          float NewFov = FOV - 20;
         playerCam.GetComponent<Camera>().fieldOfView += Time.unscaledDeltaTime * 70;
     playerCam.GetComponent<Camera>().fieldOfView  =  Mathf.Clamp( playerCam.GetComponent<Camera>().fieldOfView , NewFov, FOV);
     }

     if (resetRestart.activeInHierarchy == false)
     {
         StopSlowMo();
     }

     //Not letting slowmotionability time go over 10
     slowMotionAbilityTime = Mathf.Clamp(slowMotionAbilityTime, 0f, 10f);

     //Check if SlowMo should be active
   if (Input.GetKeyDown(KeyCode.Q) && slowMotionAbilityTime > 3f)
   {
       StartSlowMo();
   }

   if (Input.GetKeyUp(KeyCode.Q))
   {
       StopSlowMo();
   }

   //Checking if the Slow motion Ability time ran out

   if (slowMotionAbilityTime <= 0f)
   {
       StopSlowMo();
   }

    //Checking if the game should minus or add Slow motion ability time

    if (addAbilityTime == true && minusAbilityTime == false)
    {
        slowMotionAbilityTime += Time.unscaledDeltaTime;
    }

    if(minusAbilityTime == true && addAbilityTime == false)
    {
        slowMotionAbilityTime -= Time.unscaledDeltaTime * 3f;
    }

   Debug.Log(slowMotionAbilityTime);
 }



 void StopSlowMo()
 {
     //Stops the slow mo
     Time.timeScale = startTimeScale;
     Time.fixedDeltaTime = startFixedDeltaTime;
     movement.speed = 7f;
     MouseLook.mouseSensitivity = PlayerPrefs.GetFloat("NewSens");
     minusAbilityTime = false;
     addAbilityTime = true;
     
     isUsing = false;
     
    
    
     
 }

 void StartSlowMo()
 {
     //Starts the slowmo
     Time.timeScale = SlowDownFactor;
     Time.fixedDeltaTime = startFixedDeltaTime * SlowDownFactor;
     movement.speed = 35f;
     MouseLook.mouseSensitivity = startMouseSens * 2;
     minusAbilityTime = true;
     addAbilityTime = false;
     isUsing = true;
     
     

 }
 void StopUsing()
 {
     
     
 }
}
