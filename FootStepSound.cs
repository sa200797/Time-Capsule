using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FootStepSound : MonoBehaviour
{
    CharacterController cc;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();
    }

    

    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 0.3 && audio.isPlaying == false)        {
           
            audio.Play();
        }
    }
}
