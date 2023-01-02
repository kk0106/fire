using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{
    public GameObject plight;
    public static int a;
    
    
    // Start is called before the first frame update
    void Start()
    {
        plight.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "1")
        {
            plight.SetActive(true);
            a = 1;
            
        }
    }
}
