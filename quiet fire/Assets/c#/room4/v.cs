using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v : MonoBehaviour
{
    public  GameObject a;
    public static float timer=30;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 13)
        {
            a.SetActive(false);
        }
        else
        {
            if (timer <= 16)
            {
                a.SetActive(true);
            }
        }

        
        
            
       
    }
}
