using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide_Box : MonoBehaviour
{
    public GameObject[] objects;

    bool object1;
    bool object2;
    bool object3;
    bool object4;
    bool object5;
    bool object6;
    bool object7;



    #region All Collison Detection

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object1")
        {
            Debug.Log("Object1 collided");
        }
        if (collision.gameObject.tag == "Object2")
        {
            Debug.Log("Object1 collided");
        }
        if (collision.gameObject.tag == "Object3")
        {
            Debug.Log("Object1 collided");
        }
        if (collision.gameObject.tag == "Object4")
        {
            Debug.Log("Object1 collided");
        }
        if (collision.gameObject.tag == "Object5")
        {
            Debug.Log("Object1 collided");
        }

        if (collision.gameObject.tag == "Object6")
        {
            Debug.Log("Object1 collided");
        }
        if (collision.gameObject.tag == "Object7")
        {
            Debug.Log("Object1 collided");
        }

    }


    #endregion
}