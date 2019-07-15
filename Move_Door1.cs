using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Door1 : MonoBehaviour
{

    public GameObject gameobject;
    //Vector3 pos;
    private Vector3 spherePosition;

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
      //  gameobject.FindGameObjectWithTag(Dancing).transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        spherePosition = new Vector3(2, 5, 0);
        transform.position = spherePosition;
        //  pos = new Vector3(2, 5, 0);

        if (gameObject.transform.position == spherePosition)
        {
            //Debug.Log("Yes!!");
            anim.SetBool("DoorOpen1", true);

        }
    }



    /* if (gameObject.transform.Translate == new Vector3(2, 5, 0) = true)
     {
         anim.SetBool("MoveDoor", true);
         Debug.Log("Yes!!");
     }
     else
     {
         Debug.Log("No");
     }
     */
}

