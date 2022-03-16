using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class PPEController : MonoBehaviour
{
  [SerializeField] private PostProcessVolume _postProcessVolume;

  private  Bloom _bloom;
  private ColorGrading _CC;

  private void Start()
  {
      _postProcessVolume.profile.TryGetSettings(out _bloom);
      _postProcessVolume.profile.TryGetSettings(out _CC);
      
  }
  void Awake()
  {
      DontDestroyOnLoad(this);
  }

  public void Update()
  {
      
      if (PlayerPrefs.GetString("Bloom") == "On")
      {
          _bloom.active = true;
      }
      else if (PlayerPrefs.GetString("Bloom") == "Off")
      {
          _bloom.active = false;
          
      }

      if (PlayerPrefs.GetString("ColorGrading") == "On")
      {
          _CC.active = true;
      }
      else if (PlayerPrefs.GetString("ColorGrading") == "Off")
      {
          _CC.active = false;
      }

      if (PlayerPrefs.GetString("ColorGradingMode") == "On")
      {
          _CC.tonemapper.value = Tonemapper.ACES;
        
      }

      else if (PlayerPrefs.GetString("ColorGradingMode") == "Off")
      {
          _CC.tonemapper.value = Tonemapper.None;
          
      }
  }
}
