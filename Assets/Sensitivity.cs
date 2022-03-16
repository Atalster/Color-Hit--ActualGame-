using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sensitivity : MonoBehaviour
{

    [SerializeField] private Slider _slider;
    [SerializeField] private Text Sensvalue;
    public Animator Arrow5;
    public Animator Arrow6;
    public GameObject arrow5;
    public GameObject arrow6;


    // Start is called before the first frame update
    void Start()
    {
         
            _slider.onValueChanged.AddListener((newSens) => {
                PlayerPrefs.SetFloat("NewSens", newSens);
                MouseLook.mouseSensitivity = PlayerPrefs.GetFloat("NewSens");
                Sensvalue.text = PlayerPrefs.GetFloat("NewSens").ToString("00.00");
            });

                _slider.value = PlayerPrefs.GetFloat("NewSens");
                MouseLook.mouseSensitivity = PlayerPrefs.GetFloat("NewSens");
                Sensvalue.text = PlayerPrefs.GetFloat("NewSens").ToString("00.00");
    }

    // Update is called once per frame
    void Update()
    {
            if (PlayerPrefs.GetFloat("NewSens") == 0 && PlayerPrefs.GetFloat("NewSens") < 1  )
            {
                 arrow5.SetActive(true);
                arrow6.SetActive(true);
                Arrow5.Play("SettingArrows");
                Arrow6.Play("SettingArrows");
            }

            else if (PlayerPrefs.GetFloat("NewSens") > 1)
            {
                arrow5.SetActive(false);
                arrow6.SetActive(false);
            }
    }
}
