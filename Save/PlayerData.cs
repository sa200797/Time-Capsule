using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public float level;
    public float k_level;

    public float[] position;


    public PlayerData(Knowledge_Bar knowledge_bar)
    {
        level = knowledge_bar.level;  //  refrence from player data;
        k_level = knowledge_bar.c_knowledge;

        position = new float[3];
        position[0] = knowledge_bar.transform.position.x;
        position[1] = knowledge_bar.transform.position.y;
        position[2] = knowledge_bar.transform.position.z;

    }

}