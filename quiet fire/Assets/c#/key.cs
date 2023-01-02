using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
   
    public static float y;
    public float timer ;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        if (keypad.no == 0)
        {
            b.SetActive(false);
           
        }

        if (Input.GetKey(KeyCode.E))
        {
            a.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (keypad.no == 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            timer -= Time.deltaTime;
            b.SetActive(true);
            


            if (timer <= 0)
            {
                b.SetActive(false);
                Invoke("returna",1f);
                keypad.no = 0;
            }
        }

       
    }
    private void returna()
    {
        if (b.activeInHierarchy)
        {
            Debug.Log("none");
        }
        else
        {
            timer = 1;
            y = 1;
        }
    }
}
