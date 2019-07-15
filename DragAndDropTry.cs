using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DragAndDropTry : MonoBehaviour
{
    public bool cube1;
    public bool cube2;
    public bool cube3;
    public bool cube4;
    public bool cube5;
    public bool cube6;

    public GameObject Doors;

    public AudioSource playsound;
    public AudioClip sound;

    public Knowledge_Bar knowledge;



    public ParticleSystem D_system;
    public ParticleSystem E_system;

    public GameObject objectone;

   


    private Animator anim;

   


    private void Start()
    {
        gameObject.GetComponent<BoxCollider>();
        gameObject.GetComponent<Rigidbody>();

        playsound.GetComponent<AudioSource>();
        playsound.clip = sound;
        playsound.playOnAwake = false;

        knowledge = GameObject.FindWithTag("Player").GetComponentInChildren<Knowledge_Bar>();


        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindGameObjectWithTag("Target1") && collision.gameObject.CompareTag("Stone1"))
        {
            Debug.Log("k");
            cube1 = true;
        }

        if (GameObject.FindGameObjectWithTag("Target2") && collision.gameObject.CompareTag("Stone2"))
        {
            cube2 = true;
        }

        if (GameObject.FindGameObjectWithTag("Target3") && collision.gameObject.CompareTag("Stone3"))
        {
            cube3 = true;
        }

        if (GameObject.FindGameObjectWithTag("Target4") && collision.gameObject.CompareTag("Stone4"))
        {
            cube4 = true;
        }

        if (GameObject.FindGameObjectWithTag("Target5") && collision.gameObject.CompareTag("Stone5"))
        {
            cube5 = true;
        }

        if (GameObject.FindGameObjectWithTag("Target6") && collision.gameObject.CompareTag("Stone6"))
        {
            cube6 = true;
        }



    }

    private void Update()
    {
        if (cube1 && cube2 && cube3 && cube4 && cube5 && cube6 == true)
        {
            anim = Doors.GetComponent<Animator>();
            anim.SetBool("OpenDoor", true);
            playsound.PlayOneShot(sound); 

            knowledge.level =+ 0.25f;
           knowledge.L_bar.fillAmount = knowledge.level;

          


            D_system.Play();
            E_system.Play();

            Destroy(objectone, 10f);

            StartCoroutine(EffectSpawn());

           

            

        }
    }


    IEnumerator EffectSpawn()
    {
        yield return new WaitForSeconds(1.0f);

        D_system.enableEmission = false;
     
       
    }

    public void soundPlay()
    {
      
    }
   
}


