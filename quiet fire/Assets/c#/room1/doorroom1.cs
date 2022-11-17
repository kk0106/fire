using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorroom1 : MonoBehaviour
{
    public GameObject pointlight;
    public GameObject pointlight1;
    public GameObject pointlight2;
    public GameObject pointlight3;
    public GameObject door_1;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        door_1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointlight.activeSelf)
        {

            door_1.SetActive(true);
        }
       


       
    }
    
            
     
    

}
