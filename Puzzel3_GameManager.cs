using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puzzel3_GameManager : MonoBehaviour
{
    public Knowledge_Bar knowledge;

    Animator anim;

    public GameObject Gate;
  
    public ParticleSystem E_particle;

    public TextMeshProUGUI war4;

    private void Start()
    {
       
        anim = Gate.GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            knowledge = Player_GameManager.Instance.myPlayerKnowledge;
            war4 = Player_GameManager.Instance.myText;

            if (knowledge.level >= 0.50)
            {
                anim.SetBool("Door3", true);



              
                E_particle.Play();

                knowledge.level = +0.25f;
                knowledge.L_bar.fillAmount = knowledge.level;


              
            }
            else
            {
                war4.text = "Need TO Get Level Up";
                StartCoroutine(Info_Disable());
            }
        }
    }


   
    IEnumerator Info_Disable()
    {
        yield return new WaitForSeconds(3.0f);
        war4.text = " ";
    }


}
