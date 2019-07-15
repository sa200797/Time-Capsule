using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzel_4 : MonoBehaviour
{
    public GameObject obj;
    public bool clicked = false;
    string key = "", value;
    char ch1, ch2;
    int tries = 0;

    public LayerMask hitmask;

    private string correctPass = "1432";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 up = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, up * 5, Color.red, hitmask);
        if (Physics.Raycast(transform.position, up, out hit, 5))
        {
            if (hit.collider.gameObject.tag == "Cube")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    value = hit.collider.gameObject.name;
                    //Debug.Log (key);
                    CombinePass();
                    PassCheck();
                    tries += 1;


                }
            }
        }
        if (tries >= 4 && key == correctPass)
        {
            Debug.Log("Scnee cahngbe");
        }
        if (tries >= 4)
        {
            ResetPuzzle();
        }
    }

    void CombinePass()
    {
        key += string.Concat(value);
        Debug.Log(key);
    }

    void PassCheck()
    {
        if (key[tries] == correctPass[tries])
        {
            Debug.Log("Good");
        }
        else
        {
            Debug.Log("Bad");
            ResetPuzzle();
        }
    }

    void ResetPuzzle()
    {
        key = "";
        tries = 0;
        Application.Quit();
    }
}