
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public   class  Knowledge_Bar : MonoBehaviour
{

    [SerializeField]
    public Image K_bar;
    [SerializeField]
    public Image L_bar;

    public float c_knowledge = 0.0f;

    public float level = 0.0f;

    public TextMeshProUGUI info;

    private Animator anim;

    
    public GameObject Pickup1;
    public GameObject Pickup2;
    public GameObject Pickup3;
    public GameObject Pickup4;
    public GameObject Pickup5;


    public GameObject M_puzzel1;
    public GameObject M_puzzel2;
    public GameObject M_puzzel3;
    public GameObject M_puzzel4;

    public AudioSource audioSource;

    public AudioClip b_sound;
    public AudioClip sound;


    // Start is called before the first frame update
    void Start()
    {
        c_knowledge = 0.0f;
        level = 0;
        info.text = " ";

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = b_sound;
        audioSource.clip = sound;

        audioSource.playOnAwake = false;

    }

    IEnumerator Info_Disable()
    {
        yield return new WaitForSeconds(3.0f);
           info.text = " ";
    }


    // Update is called once per frame
    void Update()
    {
        //Make Function to  set refrence for gameManager
     
        //
        Vector3 up = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, up * 5, Color.yellow);
        if (Physics.Raycast(transform.position, up * 5, out hit, 10))
        {
           

            if (hit.collider.gameObject.tag == "Box" )
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T)) //())
                {
                   
                   
                    anim = hit.collider.gameObject.GetComponent<Animator>();

                    anim.SetBool("BoxOpen",true);
                    info.text = " Found A Box.";
                    StartCoroutine(Info_Disable());
                    audioSource.PlayOneShot(b_sound);
                }



            }

            if (hit.collider.gameObject.tag == "PickUp1")    // Copper Plate
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T)) //())
                {

                    c_knowledge += 0.01f;

                    


                    K_bar.fillAmount = c_knowledge;
                    Destroy(hit.collider.gameObject);
                   

                    info.text = " Found A CopperPlate.";

                    Pickup1.SetActive(true);
                    StartCoroutine(Info_Disable());

                    audioSource.PlayOneShot(sound);
                }



            }

            if (hit.collider.gameObject.tag == "PickUp2")   // Jewellery
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T)) //(Input.GetKey(KeyCode.T))
                {

                    c_knowledge += 0.02f;



                    K_bar.fillAmount = c_knowledge;
                    Destroy(hit.collider.gameObject);
                    Debug.Log(c_knowledge);

                    info.text = " Found A Jewellery.";

                    Pickup2.SetActive(true);
                    StartCoroutine(Info_Disable());
                    audioSource.PlayOneShot(sound);
                }



            }
            if (hit.collider.gameObject.tag == "PickUp3") //Seals
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T))
                {

                    c_knowledge += 0.03f;



                    K_bar.fillAmount = c_knowledge;
                    Destroy(hit.collider.gameObject);
                    Debug.Log(c_knowledge);

                    info.text = " Found A Seals.";

                    Pickup3.SetActive(true);
                    StartCoroutine(Info_Disable());
                    audioSource.PlayOneShot(sound);
                }



            }
            if (hit.collider.gameObject.tag == "PickUp4") //Weapons;
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T)) //(Input.GetKey(KeyCode.T))
                {

                    c_knowledge += 0.04f;



                    K_bar.fillAmount = c_knowledge;
                    Destroy(hit.collider.gameObject);
                    Debug.Log(c_knowledge);

                    info.text = " Found A Weapon.";

                    Pickup4.SetActive(true);
                    StartCoroutine(Info_Disable());
                    audioSource.PlayOneShot(sound);
                }



            }
            if (hit.collider.gameObject.tag == "PickUp5") //ScaleMode;
            {

                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.T)) //(Input.GetKey(KeyCode.T))
                {

                    c_knowledge += 0.05f;



                    K_bar.fillAmount = c_knowledge;
                    Destroy(hit.collider.gameObject);
                    Debug.Log(c_knowledge);

                    info.text = " Found A Scale.";

                    Pickup5.SetActive(true);
                    StartCoroutine(Info_Disable());
                    audioSource.PlayOneShot(sound);
                }



            }

        }

        ActivePuzzel();
       

    }


    void ActivePuzzel()
    {
        if(level ==0.25)
        {
            M_puzzel1.SetActive(true);

        }
        if (level == 0.50)
        {
            M_puzzel1.SetActive(true);

        }
        if (level == 0.75)
        {
            M_puzzel1.SetActive(true);

        }
        if (level == 1)
        {
            M_puzzel1.SetActive(true);

        }
    }
}
