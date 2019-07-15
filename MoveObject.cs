
using UnityEngine;

public class MoveObject : MonoBehaviour
{
   

    private GameObject grabObject;
    private bool grabbing;


    public LayerMask GrabMask;

    
   

   public void DragandDrop()
    {
        grabbing = true;


        RaycastHit hit;



        Debug.DrawRay(transform.position, transform.forward * 10, Color.blue );
        if (Physics.Raycast(transform.position, transform.forward * 15, out hit, 10,GrabMask))
        {
            if (hit.collider.gameObject)
            {
                hit.collider.GetComponent<Rigidbody>().isKinematic = true;

                grabObject = hit.transform.gameObject;

                hit.collider.gameObject.transform.localPosition = hit.transform.localPosition;
                hit.collider.gameObject.transform.parent = transform;

            }

        }
    }

    public void Drop()
    {
        grabbing = false;

        if (grabObject != null)
        {


            grabObject.transform.parent = null;
            grabObject.GetComponent<Rigidbody>().isKinematic = false;

            grabObject = null;

        }
    }





    private void Update()

    {
      

        if (!grabbing && Input.GetMouseButtonDown(0))
          {
            DragandDrop();
        }

        if (grabbing && Input.GetMouseButtonUp(0))
        {
            Drop();

        }


        if (!grabbing && OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            DragandDrop();
        }

        if (grabbing && OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            Drop();

        }



    }

}


