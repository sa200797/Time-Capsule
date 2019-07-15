using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Goto_Puzzel4 : MonoBehaviour
{
    public Knowledge_Bar knowledge;

    public TextMeshProUGUI war2;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
               if (knowledge.level == 0)
                {
                SceneManager.LoadSceneAsync(5);

                
            }

            else
            {
                war2.text = "Need To Solve Puzzel One";
                StartCoroutine(Info_Disable());
            }

        }
    }

    IEnumerator Info_Disable()
    {
        yield return new WaitForSeconds(3.0f);
        war2.text = " ";
    }



    private void Start()
    {

        knowledge = GameObject.FindWithTag("Player").GetComponentInChildren<Knowledge_Bar>();
    }
}

