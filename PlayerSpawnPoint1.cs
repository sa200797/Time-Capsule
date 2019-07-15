using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint1 : MonoBehaviour
{
   

    //public GameObject player;
  
    public Knowledge_Bar knowledge;


    public void Awake()
    {
       // Player_GameManager.Instance.spawnPoints = transform;

    }
        public void Start()
        {

        
        /*

        if (knowledge.level == 0.0)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 0, 0);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(PlayerPrefs.GetFloat("Playerx"), PlayerPrefs.GetFloat("Playery"), PlayerPrefs.GetFloat("Playerz"));
        }

        if (knowledge.level == 0.25)
        {

            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(PlayerPrefs.GetFloat("Playerx"), PlayerPrefs.GetFloat("Playery"), PlayerPrefs.GetFloat("Playerz"));

        }





        if (knowledge.level == 0.45)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = spawnPoint1;
            SaveSystem.SavePlayer(knowledge);
        }


        if (knowledge.level == 1)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = spawnPoint1;
            SaveSystem.SavePlayer(knowledge);
        }*/
      }

    public void Update()
    {
        knowledge = Player_GameManager.Instance.myPlayerKnowledge;
    }
}

    

