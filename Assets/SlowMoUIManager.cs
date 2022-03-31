using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMoUIManager : MonoBehaviour
{

        public Image AbilityBarUI;
        public CanvasGroup SliderCanvasGroup;
        public SlowMo slowMo;
        int Value;
        float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (slowMo.isUsing == true )
        {
            Value = 1;
        }
        if (slowMo.isUsing == false )
        {
            Value = 0;
        }

        StartCoroutine(UpdateAbility(Value));
    }

    // Update is called once per frame
    public IEnumerator UpdateAbility(int value)
    {   
           AbilityBarUI.fillAmount = slowMo.slowMotionAbilityTime / slowMo.maxSlowMotionAbilityTime;
        
           if (value == 0)
           {
               if (AbilityBarUI.fillAmount == 1)
               {
                  
                   SliderCanvasGroup.alpha = 0;
               }
               
           }
           else 
           {
               SliderCanvasGroup.alpha = 1;
           }
           yield return x;
    }

    
}
