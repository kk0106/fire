using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour
{
    public GameObject a;
    public static float timer=22f ;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
            timer -= Time.deltaTime;


            if (timer <= 0)
            {
                a.SetActive(true);
          
            }
        
        
          
     
    }

    
}
