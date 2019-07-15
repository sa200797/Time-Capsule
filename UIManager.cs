using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject secUI;


    public GameObject Load_Ui;

    public GameObject Main_Obj;
    public GameObject collectables;
    public GameObject knowledge_bar;
    public GameObject setting_bar;
    public GameObject q_pannel;


    // Start is called before the first frame update
    void Start()
    {
         

        MainUI.SetActive(true);
        Main_Obj.SetActive(false);
        collectables.SetActive(false);
        secUI.SetActive(false);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(false);
        q_pannel.SetActive(false);
        Load_Ui.SetActive(false);

 
    }
   
    public void  infoPannel()
    {
        secUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void exitPannel()
    {
        secUI.SetActive(false);
        collectables.SetActive(false);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(false);
        q_pannel.SetActive(false);
        Main_Obj.SetActive(false);
        Time.timeScale = 1f;

    }

    public void main_obje()
    {
        Main_Obj.SetActive(true);
        collectables.SetActive(false);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(false);
        q_pannel.SetActive(false);
    }




    
   public void coll_pannel()
    {
        Main_Obj.SetActive(false);
        collectables.SetActive(true);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(false);
        q_pannel.SetActive(false);

    }


    public void knowl_pannel()
    {
        Main_Obj.SetActive(false);
        collectables.SetActive(false);
        knowledge_bar.SetActive(true);
        setting_bar.SetActive(false);
        q_pannel.SetActive(false);
    }

    public void setting_pannel()
    {
        Main_Obj.SetActive(false);
        collectables.SetActive(false);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(true);
        q_pannel.SetActive(false);
    }

    public void Q_bar()
    {
        Main_Obj.SetActive(false);
        collectables.SetActive(false);
        knowledge_bar.SetActive(false);
        setting_bar.SetActive(false);
        q_pannel.SetActive(true);
    }

    private void Update()
    {
        if(OVRInput.Get(OVRInput.Button.Back))
        {
            infoPannel();
        }

       
    }


    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
