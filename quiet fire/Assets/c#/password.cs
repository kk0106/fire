using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class password : MonoBehaviour
{
    public string curpassword = "12345";
    public string input;

    public bool ontrigger;
    public bool opendoor;
    public bool keypadscreen;
    public Transform doorhinge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input == curpassword)
        {
            opendoor = true;
        }
        if (opendoor == true)
        {

            Destroy(this.gameObject);
        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ontrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        ontrigger = false;
        keypadscreen = false;
        input = "";
    }
    private void OnGUI()
    {
        if (!opendoor)
        {
            if (ontrigger)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "press'E' to open kaypad");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    keypadscreen = true;
                    ontrigger = false;
                }
            }

            if (keypadscreen)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);
                if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {

                    input = input + "1";
                }
                if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
                {

                    input = input + "2";
                }
                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {

                    input = input + "3";
                }
                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {

                    input = input + "4";
                }
                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {

                    input = input + "5";
                }
                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {

                    input = input + "6";
                }
                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {

                    input = input + "7";
                }
                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {

                    input = input + "8";
                }
                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {

                    input = input + "9";
                }
                if (GUI.Button(new Rect(350, 110, 100, 100), "0"))
                {
                    input = input + "0";
                }
            }
        }
    }
}
