using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player_GameManager : Singleton<Player_GameManager>
{
    public static Player_GameManager manager;

    public  Knowledge_Bar myPlayerKnowledge;
    public  TextMeshProUGUI myText;
    public  GameObject menu;
    public  GameObject loading;
    public int oldLevel=0;
    public int curLevel=0;
    public GameObject player;

 
    

    public  Transform S_spawnpoint;

    public static int currectLevel=0;

    public  Transform[] spawnPoints;

   

    // Start is called before the first frame update
    public void Awake()
    {
       
        

    }
    private void Start()
    {
      
    }
    void GetRefrences()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
     
          
    }



}
