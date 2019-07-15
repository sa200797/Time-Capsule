using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Skybox : MonoBehaviour
{
    public Material skybox1;
     public Material skybox2;
    // public Material skybox3;
    // public Material skybox4;
    // public Material skybox5;
    // public Material skybox6;

   

    public Light sun;
    public float secondsInFullDay = 120f;
    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    [HideInInspector]
    public float timeMultiplier = 1f;

    float sunInitialIntensity;

    void Start()
    {
       
    }

    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }

       
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);

       

        if (currentTimeOfDay >= 0.0f )
        {
            RenderSettings.skybox = skybox1;
            sun.intensity =0.27f ;
            sun.color = new Color32(226,155,91,255);
            DynamicGI.UpdateEnvironment();
        }
        if (currentTimeOfDay >= 0.6)
        {
            RenderSettings.skybox = skybox2;
            sun.intensity = 1;
            sun.color = new Color32(238,235,203,255);
           
            DynamicGI.UpdateEnvironment();
        }


      /*   if (currentTimeOfDay >= 0.30f)
        {
            RenderSettings.skybox.Lerp(RenderSettings.skybox = skybox2, RenderSettings.skybox = skybox3, .5f * Time.deltaTime);
            sun.intensity = 1;
            sun.color = new Color32(248,242,212,255);
            DynamicGI.UpdateEnvironment();
        }
         if (currentTimeOfDay >= 0.45f)
        {
            RenderSettings.skybox.Lerp(RenderSettings.skybox = skybox3, RenderSettings.skybox = skybox4, .5f * Time.deltaTime);
            sun.intensity = 1;
            sun.color = new Color32(235,253,255,255);
            DynamicGI.UpdateEnvironment();
        }
         if (currentTimeOfDay >= 0.60f)
        {
            RenderSettings.skybox.Lerp(RenderSettings.skybox = skybox4, RenderSettings.skybox = skybox5, .5f * Time.deltaTime);
            sun.intensity = 0.59f;
            sun.color = new Color32(248,192,137,255);
            DynamicGI.UpdateEnvironment();
        }
         if (currentTimeOfDay >= 0.75f)
        {
            RenderSettings.skybox.Lerp(RenderSettings.skybox = skybox5, RenderSettings.skybox = skybox6, .5f * Time.deltaTime);
            sun.intensity = 0.9f;
            sun.color = new Color32(81, 144, 143,255);
            DynamicGI.UpdateEnvironment();
        }
        */
    }
}

