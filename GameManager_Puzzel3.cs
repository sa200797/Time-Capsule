using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager_Puzzel3 : MonoBehaviour
{
    public Knowledge_Bar knowledge;

    public TextMeshProUGUI war3;

    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            if (knowledge.level >= 0.50)
            {

            }

            else
            {
                war3.text = "Need TO Get Level Up";
                StartCoroutine(Info_Disable());
            }

        }
    }

    IEnumerator Info_Disable()
    {
        yield return new WaitForSeconds(3.0f);
        war3.text = " ";
    }


    private void Start()
    {

        knowledge = GameObject.FindWithTag("Player").GetComponentInChildren<Knowledge_Bar>();
    }
}
