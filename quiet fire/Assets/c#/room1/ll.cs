using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ll : MonoBehaviour
{
   // Vector3 v1;
    public GameObject b;
    public GameObject pointlight;

    
    

    // Start is called before the first frame update
    void Start()
    {
        pointlight.SetActive(false);
       
       
    }

    // Update is called once per frame
    void Update()
    {

        

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "1")
       {
     
            pointlight.SetActive(true);
           
        }
        else
        {
            Debug.Log("none");
        }
    }
}
