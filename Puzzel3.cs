using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzel3 : MonoBehaviour
{
    public OVRInput.Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 up = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, up * 5, Color.yellow);
        if (Physics.Raycast(transform.position,up,out hit,10))
        {
            if (hit.collider.gameObject.tag == "Rotate")
            {
               
            

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    hit.transform.Rotate(Vector3.forward, 1);
                }

               
                else if (OVRInput.Get(OVRInput.Button.DpadLeft))
                {
                   hit.transform.Rotate(Vector3.forward, 1);
                }

               else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
                {
                   hit.transform.Rotate(Vector3.right, 1);
                }
                else if (OVRInput.Get(OVRInput.Button.DpadDown))
                {
                    hit.transform.Rotate(Vector3.forward, 1);
                }


                if (Input.GetKey(KeyCode.D))
                {
                    hit.transform.Rotate(Vector3.down, 1);
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    hit.transform.Rotate(Vector3.right, 1);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    hit.transform.Rotate(Vector3.forward, 1);
                }
            }

        }

      
    }

   /* public void MoveCube()
    {
               

       
    }*/
}
