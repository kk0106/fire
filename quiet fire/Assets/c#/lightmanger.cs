using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmanger: MonoBehaviour
{
    public GameObject pointlight;
    public GameObject pointlight1;
    public GameObject pointlight2;
    public GameObject pointlight3;
    public GameObject pointlight4;
    public GameObject pointlight5;
    public GameObject finalpl;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
   // public GameObject door4;
    public GameObject starttex;
    public GameObject texbox;
    
    //public static int clear;
    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if (value.clear == 0)
        {
            starttex.SetActive(true);
            pointlight.SetActive(true);
            pointlight1.SetActive(true);
            pointlight2.SetActive(false);
            pointlight3.SetActive(false);
            pointlight4.SetActive(false);
            pointlight5.SetActive(false);
            finalpl.SetActive(false);
            door1.SetActive(true);
            door2.SetActive(false);
            door3.SetActive(false);
           // door4.SetActive(false);
            texbox.SetActive(false);


        }
       if (value.clear == 1)
        {
            starttex.SetActive(false);
            pointlight.SetActive(false);
            pointlight1.SetActive(false);
            pointlight2.SetActive(true);
            pointlight3.SetActive(true);
            pointlight4.SetActive(false);
            pointlight5.SetActive(false);
            finalpl.SetActive(false);
            door1.SetActive(false);
            door2.SetActive(true);
            door3.SetActive(false);
           // door4.SetActive(false);
           texbox.SetActive(false);

        }
        if (value.clear == 2)
        {
            starttex.SetActive(false);
            pointlight.SetActive(false);
            pointlight1.SetActive(false);
            pointlight2.SetActive(false);
            pointlight3.SetActive(false);
            pointlight4.SetActive(true);
            pointlight5.SetActive(true);
            finalpl.SetActive(false);
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(true);
           // door4.SetActive(false);
           texbox.SetActive(false);

        }
        if (value.clear == 3)
        {
            starttex.SetActive(false);
            pointlight.SetActive(false);
            pointlight1.SetActive(false);
            pointlight2.SetActive(false);
            pointlight3.SetActive(false);
            pointlight4.SetActive(false);
            pointlight5.SetActive(false);
            finalpl.SetActive(true);
            door1.SetActive(false);
            door2.SetActive(false);
            door3.SetActive(false);
          //  door4.SetActive(true);
            texbox.SetActive(true);
            if (keypad.ll == 1)
            {
                texbox.SetActive(false);
            }

        }
        
    }
}
