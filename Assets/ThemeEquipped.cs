using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeEquipped : MonoBehaviour
{       

    public GameObject BlueBalls;
    public GameObject FakeBlueBall;
    public GameObject RedBalls;
    public GameObject FakeRedBall;
    public GameObject GreenBalls;
    public GameObject FakeGreenBall;
    public GameObject YellowBalls;
    public GameObject FakeYellowBall;
     public GameObject BlueCorner;
      public GameObject RedCorner;
       public GameObject GreenCorner;
        public GameObject YellowCorner;
        public GameObject BlueBall;
        
        public GameObject RedBall;
        
        public GameObject GreenBall;
        
        public GameObject YellowBall;
     
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

        
        // IF BRO COLORS IS EQUIPPED
        if (PlayerPrefs.GetString("BroColorsEquip") == "Equipped")
        {
            //Blue Colors rearragements
            for (int i = 0; i < BlueBalls.transform.childCount; i++)
            {
                Color c = new Color32(0, 191, 198, 255);
                float Intensity = 3f;
                 Material BlueballsMat = BlueBalls.transform.GetChild(i).GetComponent<Renderer>().material;
                 BlueballsMat.EnableKeyword("_EMISSION");
         BlueballsMat.SetColor("_EmissionColor", c * Intensity );
            
            }

             for (int z = 0; z < BlueCorner.transform.childCount; z++)
            {
                Color c = new Color32(0, 191, 198, 255);
                float Intensity = 1.5f;
                 Material BlueCornerMat = BlueCorner.transform.GetChild(z).GetComponent<Renderer>().material;
                 BlueCornerMat.EnableKeyword("_EMISSION");
         BlueCornerMat.SetColor("_EmissionColor", c * Intensity);
            
            }

            Color xx = new Color32(0, 191, 198, 255);
            float IntensityFake = 3f;
                 Material FakeBlueballMat = FakeBlueBall.transform.GetComponent<Renderer>().material;
                 FakeBlueballMat.EnableKeyword("_EMISSION");
         FakeBlueballMat.SetColor("_EmissionColor", xx * IntensityFake );
          

            //Red Color Rearrangements
              for (int x = 0; x < RedBalls.transform.childCount; x++)
            {
                float Intensity = 1.8f;
                 Material RedballsMat = RedBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 RedballsMat.EnableKeyword("_EMISSION");
         RedballsMat.SetColor("_EmissionColor", Color.white * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int c = 0; c < RedCorner.transform.childCount; c++)
            {
                float Intensity = 1.3f;
                 Material RedCornerMat = RedCorner.transform.GetChild(c).GetComponent<Renderer>().material;
                 RedCornerMat.EnableKeyword("_EMISSION");
         RedCornerMat.SetColor("_EmissionColor", Color.white * Intensity);
           
            }
                
            
            float IntensityFakeRed = 1.8f;
                 Material FakeRedballMat = FakeRedBall.transform.GetComponent<Renderer>().material;
                 FakeRedballMat.EnableKeyword("_EMISSION");
         FakeRedballMat.SetColor("_EmissionColor", Color.white * IntensityFakeRed );
            DynamicGI.UpdateEnvironment();

            //Green Color Rearrangements
            for (int x = 0; x < GreenBalls.transform.childCount; x++)
            {
                Color c = new Color32(241, 12, 142, 255);
                float Intensity = 3f;
                 Material GreenballsMat = GreenBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 GreenballsMat.EnableKeyword("_EMISSION");
         GreenballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < GreenCorner.transform.childCount; i++)
            {
                Color c = new Color32(241, 12, 142, 255);
                float Intensity = 1.3f;
                 Material GreenCornerMat = GreenCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 GreenCornerMat.EnableKeyword("_EMISSION");
        GreenCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

            Color cc = new Color32(241, 12, 142, 255);
            float IntensityFakeGreen = 3f;
                 Material FakeGreenballMat = FakeGreenBall.transform.GetComponent<Renderer>().material;
                 FakeGreenballMat.EnableKeyword("_EMISSION");
         FakeGreenballMat.SetColor("_EmissionColor", cc * IntensityFakeGreen );
            DynamicGI.UpdateEnvironment();

            //Yello Color Rearrangements

                for (int x = 0; x < YellowBalls.transform.childCount; x++)
            {
                 Color c = new Color32(191, 96, 30, 255);
                float Intensity = 3f;
                 Material YellowballsMat = YellowBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 YellowballsMat.EnableKeyword("_EMISSION");
         YellowballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < YellowCorner.transform.childCount; i++)
            {
                 Color c = new Color32(191, 96, 30, 255);
                float Intensity = 1.3f;
                 Material YellowCornerMat = YellowCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 YellowCornerMat.EnableKeyword("_EMISSION");
       YellowCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

            Color Yc = new Color32(191, 96, 30, 255);
            float IntensityFakeYellow = 3f;
                 Material FakeYellowballMat = FakeYellowBall.transform.GetComponent<Renderer>().material;
                 FakeYellowballMat.EnableKeyword("_EMISSION");
         FakeYellowballMat.SetColor("_EmissionColor", Yc * IntensityFakeYellow );
            DynamicGI.UpdateEnvironment();

        }     
                //IF HARD MODE IS EQUIPPED

            else if (PlayerPrefs.GetString("HardModeEquip") == "Equipped")
        {
            //Blue Colors rearragements
            for (int i = 0; i < BlueBalls.transform.childCount; i++)
            {
                Color c = new Color32(153, 161, 191, 255);
                float Intensity = 2.3f;
                 Material BlueballsMat = BlueBalls.transform.GetChild(i).GetComponent<Renderer>().material;
                 BlueballsMat.EnableKeyword("_EMISSION");
         BlueballsMat.SetColor("_EmissionColor", c * Intensity );
            
            }

             for (int z = 0; z < BlueCorner.transform.childCount; z++)
            {
                 Color c = new Color32(153, 161, 191, 255);
                float Intensity = 1.3f;
                 Material BlueCornerMat = BlueCorner.transform.GetChild(z).GetComponent<Renderer>().material;
                 BlueCornerMat.EnableKeyword("_EMISSION");
         BlueCornerMat.SetColor("_EmissionColor", c * Intensity);
            
            }

             Color xx = new Color32(153, 161, 191, 255);
            float IntensityFake = 2.3f;
                 Material FakeBlueballMat = FakeBlueBall.transform.GetComponent<Renderer>().material;
                 FakeBlueballMat.EnableKeyword("_EMISSION");
         FakeBlueballMat.SetColor("_EmissionColor", xx * IntensityFake );
          

            //Red Color Rearrangements
              for (int x = 0; x < RedBalls.transform.childCount; x++)
            {
                float Intensity = 1.8f;
                 Material RedballsMat = RedBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 RedballsMat.EnableKeyword("_EMISSION");
         RedballsMat.SetColor("_EmissionColor", Color.white * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int c = 0; c < RedCorner.transform.childCount; c++)
            {
                float Intensity = 1.3f;
                 Material RedCornerMat = RedCorner.transform.GetChild(c).GetComponent<Renderer>().material;
                 RedCornerMat.EnableKeyword("_EMISSION");
         RedCornerMat.SetColor("_EmissionColor", Color.white * Intensity);
           
            }

            
            float IntensityFakeRed = 1.8f;
                 Material FakeRedballMat = FakeRedBall.transform.GetComponent<Renderer>().material;
                 FakeRedballMat.EnableKeyword("_EMISSION");
         FakeRedballMat.SetColor("_EmissionColor", Color.white * IntensityFakeRed );
            DynamicGI.UpdateEnvironment();

            //Green Color Rearrangements
            for (int x = 0; x < GreenBalls.transform.childCount; x++)
            {
                Color c = new Color32(184, 191, 165, 255);
                float Intensity = 3f;
                 Material GreenballsMat = GreenBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 GreenballsMat.EnableKeyword("_EMISSION");
         GreenballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < GreenCorner.transform.childCount; i++)
            {
                Color c = new Color32(184, 191, 165, 255);
                float Intensity = 1.3f;
                 Material GreenCornerMat = GreenCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 GreenCornerMat.EnableKeyword("_EMISSION");
        GreenCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

            Color cc = new Color32(184, 191, 165, 255);
            float IntensityFakeGreen = 3f;
                 Material FakeGreenballMat = FakeGreenBall.transform.GetComponent<Renderer>().material;
                 FakeGreenballMat.EnableKeyword("_EMISSION");
         FakeGreenballMat.SetColor("_EmissionColor", cc * IntensityFakeGreen );
            DynamicGI.UpdateEnvironment();

            //Yello Color Rearrangements

                for (int x = 0; x < YellowBalls.transform.childCount; x++)
            {
                 Color c = new Color32(255, 238, 237, 255);
                float Intensity = 1.6f;
                 Material YellowballsMat = YellowBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 YellowballsMat.EnableKeyword("_EMISSION");
         YellowballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < YellowCorner.transform.childCount; i++)
            {
                 Color c = new Color32(255, 238, 237, 255);
                float Intensity = 0.9f;
                 Material YellowCornerMat = YellowCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 YellowCornerMat.EnableKeyword("_EMISSION");
       YellowCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

           Color Yc = new Color32(255, 238, 237, 255);
            float IntensityFakeYellow = 1.6f;
                 Material FakeYellowballMat = FakeYellowBall.transform.GetComponent<Renderer>().material;
                 FakeYellowballMat.EnableKeyword("_EMISSION");
         FakeYellowballMat.SetColor("_EmissionColor", Yc * IntensityFakeYellow );
            DynamicGI.UpdateEnvironment();

        } 
                //SUNSET COLORS

                else if (PlayerPrefs.GetString("SunsetEquip") == "Equipped")
                {
                            //Blue Colors rearragements
            for (int i = 0; i < BlueBalls.transform.childCount; i++)
            {
                Color c = new Color32(130, 75, 61, 255);
                float Intensity =3.8f;
                 Material BlueballsMat = BlueBalls.transform.GetChild(i).GetComponent<Renderer>().material;
                 BlueballsMat.EnableKeyword("_EMISSION");
         BlueballsMat.SetColor("_EmissionColor", c * Intensity );
            
            }

             for (int i = 0; i < BlueCorner.transform.childCount; i++)
            {
                Color c = new Color32(130, 75, 61, 255);
                float Intensity = 1.8f;
                 Material BlueCornerMat = BlueCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 BlueCornerMat.EnableKeyword("_EMISSION");
         BlueCornerMat.SetColor("_EmissionColor", c * Intensity );
        
            }

                 Color BT = new Color32(130, 75, 61, 255);
                float IntensityFake = 3.8f;
                 Material FakeBlueballMat = FakeBlueBall.transform.GetComponent<Renderer>().material;
                 FakeBlueballMat.EnableKeyword("_EMISSION");
         FakeBlueballMat.SetColor("_EmissionColor", BT * IntensityFake );


             //Red Color Rearrangements
              for (int x = 0; x < RedBalls.transform.childCount; x++)
            {
                Color b = new Color32(191, 8, 0, 255);
                float Intensity = 3f;
                 Material RedballsMat = RedBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 RedballsMat.EnableKeyword("_EMISSION");
         RedballsMat.SetColor("_EmissionColor", b * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int c = 0; c < RedCorner.transform.childCount; c++)
            {
                Color b = new Color32(191, 8, 0, 255);
                float Intensity = 1.8f;
                 Material RedCornerMat = RedCorner.transform.GetChild(c).GetComponent<Renderer>().material;
                 RedCornerMat.EnableKeyword("_EMISSION");
         RedCornerMat.SetColor("_EmissionColor", b * Intensity);
           
            }

             Color bb = new Color32(191, 8, 0, 255);
            float IntensityFakeRed = 3f;
                 Material FakeRedballMat = FakeRedBall.transform.GetComponent<Renderer>().material;
                 FakeRedballMat.EnableKeyword("_EMISSION");
         FakeRedballMat.SetColor("_EmissionColor", bb * IntensityFakeRed );
            DynamicGI.UpdateEnvironment();



                 //Green Color Rearrangements
            for (int x = 0; x < GreenBalls.transform.childCount; x++)
            {
                Color c = new Color32(191, 103, 68, 255);
                float Intensity = 3.5f;
                 Material GreenballsMat = GreenBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 GreenballsMat.EnableKeyword("_EMISSION");
         GreenballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < GreenCorner.transform.childCount; i++)
            {
                Color c = new Color32(191, 103, 68, 255);
                float Intensity = 1.8f;
                 Material GreenCornerMat = GreenCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 GreenCornerMat.EnableKeyword("_EMISSION");
        GreenCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

           Color cc = new Color32(191, 103, 68, 255);
            float IntensityFakeGreen = 3.5f;
                 Material FakeGreenballMat = FakeGreenBall.transform.GetComponent<Renderer>().material;
                 FakeGreenballMat.EnableKeyword("_EMISSION");
         FakeGreenballMat.SetColor("_EmissionColor", cc * IntensityFakeGreen );
            DynamicGI.UpdateEnvironment();



                //Yellow Color Rearrangements

                for (int x = 0; x < YellowBalls.transform.childCount; x++)
            {
                 Color c = new Color32(118, 118, 118, 255);
                float Intensity = 3f;
                 Material YellowballsMat = YellowBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 YellowballsMat.EnableKeyword("_EMISSION");
         YellowballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < YellowCorner.transform.childCount; i++)
            {
                 Color c = new Color32(118, 118, 118, 255);
                float Intensity = 2.5f;
                 Material YellowCornerMat = YellowCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 YellowCornerMat.EnableKeyword("_EMISSION");
       YellowCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

          Color Yc = new Color32(118, 118, 118, 255);
            float IntensityFakeYellow = 3f;
                 Material FakeYellowballMat = FakeYellowBall.transform.GetComponent<Renderer>().material;
                 FakeYellowballMat.EnableKeyword("_EMISSION");
         FakeYellowballMat.SetColor("_EmissionColor", Yc * IntensityFakeYellow );
            DynamicGI.UpdateEnvironment();

                }




        else{

              //Blue Colors rearragements
            for (int i = 0; i < BlueBalls.transform.childCount; i++)
            {
                Color c = new Color32(0, 78, 191, 255);
                float Intensity = 3f;
                 Material BlueballsMat = BlueBalls.transform.GetChild(i).GetComponent<Renderer>().material;
                 BlueballsMat.EnableKeyword("_EMISSION");
         BlueballsMat.SetColor("_EmissionColor", c * Intensity );
            
            }

             for (int z = 0; z < BlueCorner.transform.childCount; z++)
            {
                 Color c = new Color32(14, 84, 191, 255);
                float Intensity = 1.8f;
                 Material BlueCornerMat = BlueCorner.transform.GetChild(z).GetComponent<Renderer>().material;
                 BlueCornerMat.EnableKeyword("_EMISSION");
         BlueCornerMat.SetColor("_EmissionColor", c * Intensity);
            
            }

             Color xx = new Color32(0, 78, 191, 255);
            float IntensityFake = 3f;
                 Material FakeBlueballMat = FakeBlueBall.transform.GetComponent<Renderer>().material;
                 FakeBlueballMat.EnableKeyword("_EMISSION");
         FakeBlueballMat.SetColor("_EmissionColor", xx * IntensityFake );
          

            //Red Color Rearrangements
              for (int x = 0; x < RedBalls.transform.childCount; x++)
            {
                Color b = new Color32(191, 8, 0, 255);
                float Intensity = 2.2f;
                 Material RedballsMat = RedBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 RedballsMat.EnableKeyword("_EMISSION");
         RedballsMat.SetColor("_EmissionColor", b * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int c = 0; c < RedCorner.transform.childCount; c++)
            {
                Color b = new Color32(191, 8, 0, 255);
                float Intensity = 1.3f;
                 Material RedCornerMat = RedCorner.transform.GetChild(c).GetComponent<Renderer>().material;
                 RedCornerMat.EnableKeyword("_EMISSION");
         RedCornerMat.SetColor("_EmissionColor", b * Intensity);
           
            }

             Color bb = new Color32(191, 8, 0, 255);
            float IntensityFakeRed = 2.2f;
                 Material FakeRedballMat = FakeRedBall.transform.GetComponent<Renderer>().material;
                 FakeRedballMat.EnableKeyword("_EMISSION");
         FakeRedballMat.SetColor("_EmissionColor", bb * IntensityFakeRed );
            DynamicGI.UpdateEnvironment();

            //Green Color Rearrangements
            for (int x = 0; x < GreenBalls.transform.childCount; x++)
            {
                Color c = new Color32(10, 191, 16, 255);
                float Intensity = 3f;
                 Material GreenballsMat = GreenBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 GreenballsMat.EnableKeyword("_EMISSION");
         GreenballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < GreenCorner.transform.childCount; i++)
            {
                Color c = new Color32(10, 191, 16, 255);
                float Intensity = 1.3f;
                 Material GreenCornerMat = GreenCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 GreenCornerMat.EnableKeyword("_EMISSION");
        GreenCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

           Color cc = new Color32(10, 191, 16, 255);
            float IntensityFakeGreen = 3f;
                 Material FakeGreenballMat = FakeGreenBall.transform.GetComponent<Renderer>().material;
                 FakeGreenballMat.EnableKeyword("_EMISSION");
         FakeGreenballMat.SetColor("_EmissionColor", cc * IntensityFakeGreen );
            DynamicGI.UpdateEnvironment();

            //Yellow Color Rearrangements

                for (int x = 0; x < YellowBalls.transform.childCount; x++)
            {
                 Color c = new Color32(191, 158, 19, 255);
                float Intensity = 2.5f;
                 Material YellowballsMat = YellowBalls.transform.GetChild(x).GetComponent<Renderer>().material;
                 YellowballsMat.EnableKeyword("_EMISSION");
         YellowballsMat.SetColor("_EmissionColor",  c * Intensity );
            DynamicGI.UpdateEnvironment();
            }

             for (int i = 0; i < YellowCorner.transform.childCount; i++)
            {
                 Color c = new Color32(191, 158, 19, 255);
                float Intensity = 1.5f;
                 Material YellowCornerMat = YellowCorner.transform.GetChild(i).GetComponent<Renderer>().material;
                 YellowCornerMat.EnableKeyword("_EMISSION");
       YellowCornerMat.SetColor("_EmissionColor", c * Intensity);
           
            }

          Color Yc = new Color32(191, 158, 19, 255);
            float IntensityFakeYellow = 2.5f;
                 Material FakeYellowballMat = FakeYellowBall.transform.GetComponent<Renderer>().material;
                 FakeYellowballMat.EnableKeyword("_EMISSION");
         FakeYellowballMat.SetColor("_EmissionColor", Yc * IntensityFakeYellow );
            DynamicGI.UpdateEnvironment();

        } 
        }
    }

