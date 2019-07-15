using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public GameObject loadingScreen;
   // public Image load_image;
    public Slider slider;

   // public Text p_text;

    private AsyncOperation async;
    
  public void Start()
    {
        StartCoroutine(LoadMyScence());
    }


    IEnumerator LoadMyScence()
    {
        async = SceneManager.LoadSceneAsync(1);
        while(!async.isDone)
        {
            float progress = Mathf.Clamp01(async.progress / .9f);
            slider.value = async.progress;

         //   p_text.text = async.progress.ToString()  ;

            yield return null;
        }

    }






    /*  AsyncOperation operation = SceneManager.LoadSceneAsync(1);

    loadingScreen.SetActive(true);

    while (!operation.isDone)
    {
        float progress = Mathf.Clamp01(operation.progress / .9f);

        //load_image.fillAmount = progress;
        slider.value = operation.progress;

        yield return null;
    }
    */
}
