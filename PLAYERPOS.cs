using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERPOS : MonoBehaviour
{
    public Transform spawnPoint;
    GameObject player;

    public void Awake()
    {
      //  player = Player_GameManager.Instance.myPlayerKnowledge.transform.parent.gameObject;     
      

        player = GameObject.FindWithTag("Player");
        player.transform.position = spawnPoint.position;
    }
}

  

