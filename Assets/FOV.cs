using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FOV : MonoBehaviour
{   

    [SerializeField] private Slider _slider;
    [SerializeField] private Text Fovvalue;
    public Animator Arrow3;
    public Animator Arrow4;
    public GameObject arrow3;
    public GameObject arrow4;
    public float MinFov = 25;
    
  
    
    // Start is called before the first frame update
    void Start()
    {   
        
        _slider.onValueChanged.AddListener((newFov) => {
            PlayerPrefs.SetFloat("NewFov", newFov);
            
            Fovvalue.text = PlayerPrefs.GetFloat("NewFov").ToString("00.00");

        });
            _slider.value = PlayerPrefs.GetFloat("NewFov");
        
            Fovvalue.text = PlayerPrefs.GetFloat("NewFov").ToString("00.00");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("NewFov") >= MinFov && PlayerPrefs.GetFloat("NewFov") <= 60 )
        {
            arrow3.SetActive(true);
            arrow4.SetActive(true);
            Arrow4.Play("SettingArrows");
            Arrow3.Play("SettingArrows");
        }

        else if (PlayerPrefs.GetFloat("NewFov") > 60)
        {
            arrow3.SetActive(false);
            
            arrow4.SetActive(false);
        }

    }
}
