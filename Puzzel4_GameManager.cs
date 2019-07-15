using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzel4_GameManager : MonoBehaviour
{
    public ParticleSystem D_Particle;
    public ParticleSystem E_particle;

    public GameObject MainObject;


    public GameObject FirstGate;
    public GameObject SecomdGate;
    public GameObject ThirdGate;
    public GameObject MiddleGate;
    public GameObject Bricks;
    public GameObject MainGate;


    public AudioSource playsound;
    public AudioClip sound;

    public Knowledge_Bar knowledge;

    Animator anim, anim1,anim2,anim4,anim5,anim6;




    private void Start()
    {
        anim = FirstGate.GetComponent<Animator>();
        anim1 = SecomdGate.GetComponent<Animator>();
        anim2 = ThirdGate.GetComponent<Animator>();
        anim4 = MiddleGate.GetComponent<Animator>();
        anim5 = Bricks.GetComponent<Animator>();
        anim6 = MainGate.GetComponent<Animator>();

        playsound.GetComponent<AudioSource>();
        playsound.clip = sound;
        playsound.playOnAwake = false;

        knowledge = GameObject.FindWithTag("Player").GetComponentInChildren<Knowledge_Bar>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            D_Particle.Play();
            E_particle.Play();

            playsound.PlayOneShot(sound);
            MainObject.SetActive(false);

            anim.SetBool("first_wall", true);
            anim1.SetBool("Second_Wall", true);
            anim2.SetBool("ThirdWall", true);
          
            anim4.SetBool("MiddleWall", true);
            anim5.SetBool("bricks_move", true);
            anim6.SetBool("MainGate", true);


            knowledge.level = +0.25f;
            knowledge.L_bar.fillAmount = knowledge.level;




            StartCoroutine(EffectSpawn());

        }
    }
    IEnumerator EffectSpawn()
    {
        yield return new WaitForSeconds(10.0f);

        D_Particle.enableEmission = false;

    }

}
