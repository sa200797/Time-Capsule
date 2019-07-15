using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GameManager : MonoBehaviour
{
   public void NewGAme()
    {
        SceneManager.LoadSceneAsync(2);


    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
    

    public void Quit()
    {
        Application.Quit();
    }



}
