using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBack : MonoBehaviour
{
    public Knowledge_Bar knowledge;


    public GameObject player;
   

   // public GameObject MainUi;
   // public GameObject LoadUi;

   /// private AsyncOperation async;
   /// public Image image;

    private void Update()
    {

        player = GameObject.Find("Player");

      

        

    }
    // Start is called before the first frame update



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

          

            SceneManager.LoadSceneAsync(3);

           
            
        }

    }
/*
    IEnumerator LoadMyScence()
    {
          async = SceneManager.LoadSceneAsync(4);

       


        while (!async.isDone)
        {
            float progress = Mathf.Clamp01(async.progress / .9f);

            image.fillAmount = async.progress;

            //   p_text.text = async.progress.ToString()  ;

            yield return null;
        }

    }

    */


}
