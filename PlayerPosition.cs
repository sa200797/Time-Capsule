using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject player;

    public Transform spawnPoint;

    public void Awake()
    {
        Instantiate(player, transform.position, Quaternion.identity);
    }

    public void Start()
    {
        if(Player_GameManager.currectLevel == 1)
        {
            player.transform.position = spawnPoint.position;
            Debug.Log(spawnPoint);
        }
    }
}



