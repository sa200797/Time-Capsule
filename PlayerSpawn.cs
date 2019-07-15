using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject player;

    public Transform spawnP;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player,spawnP.position,spawnP.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
