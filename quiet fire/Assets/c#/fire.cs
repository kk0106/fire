using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
   
    //public GameObject firepoint;
    // public GameObject ex1;
    public GameObject fire1;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.F))
        //{
        //  Rigidbody clonel;
        //clonel = Instantiate(fire1, transform.position, transform.rotation);
        //clonel.velocity = transform.TransformDirection(Vector3.forward * 50);
        //}

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(fire1, transform.position, transform.rotation);
            
        }
    }
   
}
