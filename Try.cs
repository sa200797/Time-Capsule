using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try : MonoBehaviour
{
    public bool enableFFR = true;
    public bool enable72HZ = true;

   

    private void Start()
    {
        if (enableFFR)
            OVRManager.tiledMultiResLevel = OVRManager.TiledMultiResLevel.LMSHigh;

        if (enable72HZ)
            OVRManager.display.displayFrequency = 72.0f;
        
    }

    
}

