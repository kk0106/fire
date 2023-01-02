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
    //public GameObject tex;
    public GameObject tex1;
    public float timer =5;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        door_1.SetActive(false);
        //tex.SetActive(false);
        tex1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (pointlight.activeInHierarchy&&pointlight1.activeInHierarchy&&pointlight2.activeInHierarchy&&pointlight3.activeInHierarchy)
        {
            timer -= Time.deltaTime;
            door_1.SetActive(true);
            tex1.SetActive(true);
            if (timer <= 0)
            {
               // tex.SetActive(false);
                tex1.SetActive(false);
            }
          
        }
        else
        {
            door_1.SetActive(false);
        }
       
        

       
    }
    
            
     
    

}
