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
    public static int clear;
    // Start is called before the first frame update
    void Start()
    {
       
        pointlight2.SetActive(false);
        pointlight3.SetActive(false);
        pointlight4.SetActive(false);
        pointlight5.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
