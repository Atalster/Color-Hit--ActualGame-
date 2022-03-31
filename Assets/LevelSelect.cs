using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    public static float Clicks02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLevel01Click()
    {
        SceneManager.LoadScene("Level1");

    }

    public void OnLevel02Click()
    {
        SceneManager.LoadScene("Level02");
        Clicks02 += 1f;
        PlayerPrefs.SetFloat("Level02Clicks", Clicks02);
    }

     public void OnLevel03Click()
    {
        SceneManager.LoadScene("Level03");
        
    }
}
