using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIPostion : MonoBehaviour
{
    public Transform spawnPos;
     GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //player.transform.position = this.transform.position;

        Vector3 playerpos = new Vector3(0, 2, 0);
        player.transform.position = playerpos;

        Debug.Log(player.transform.position);
    }

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
