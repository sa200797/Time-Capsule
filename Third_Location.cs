using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Third_Location : MonoBehaviour
{

    public TextMeshProUGUI k_bar;

    public GameObject K_loc1;



    private void Start()
    {
        k_bar.text = " ";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            k_bar.text = "Found A New Location ";
            K_loc1.SetActive(true);
            StartCoroutine(k_dis());
        }
    }


    IEnumerator k_dis()
    {
        yield return new WaitForSeconds(3.0f);
        k_bar.text = " ";
    }
}
