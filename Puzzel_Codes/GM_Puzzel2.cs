using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_Puzzel2 : MonoBehaviour
{
    public GameObject puzzel_gameObject;
    // Start is called before the first frame update

    public GameObject Door1;
    public GameObject Door2;

    Animator anim;
    Animator anim1;

    public Knowledge_Bar knowledge;

    public ParticleSystem dust;
    public ParticleSystem glow;


    public AudioSource playsound;
    public AudioClip sound;


    public void RotateRight()
    {
        puzzel_gameObject.transform.Rotate(Vector3.up, 5);
    }



    void Start()
    {

        playsound.GetComponent<AudioSource>();
        playsound.clip = sound;
        playsound.playOnAwake = false;


        puzzel_gameObject.GetComponent<Transform>();

        knowledge = GameObject.FindWithTag("Player").GetComponentInChildren<Knowledge_Bar>();
    }

    

    // Update is called once per frame
    void Update()
    {

        if ((puzzel_gameObject.transform.rotation.eulerAngles.y >= 90 ))
          

            {
                 anim = Door1.GetComponent<Animator>();
                 anim1 = Door2.GetComponent<Animator>();

                 anim.SetBool("DoorOpen1", true);
                  anim1.SetBool("DoorOpen", true);

            knowledge.level = +0.25f;
            knowledge.L_bar.fillAmount = knowledge.level;

            playsound.PlayOneShot(sound);

            dust.Play();
            glow.Play();
            StartCoroutine(EffectSpawn());


        }

    

        if (Input.GetKeyDown(KeyCode.T))
        {
            puzzel_gameObject.transform.Rotate(Vector3.up, 5);
        }

        

    }

  

    IEnumerator EffectSpawn()
    {
        yield return new WaitForSeconds(2.0f);

        dust.enableEmission = false;

    }

   

}
