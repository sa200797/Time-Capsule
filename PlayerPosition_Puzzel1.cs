using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition_Puzzel1 : MonoBehaviour
{
    public Vector3 spoint;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").transform.position = spoint;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
