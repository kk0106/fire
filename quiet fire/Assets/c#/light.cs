using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    Vector3 v1;
    public GameObject b;
    
    

    // Start is called before the first frame update
    void Start()
    {
        v1 = b.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(KeyCode.F))
       // {

         //   b.gameObject.GetComponent<Renderer>().material.color = new Color(231, 82, 82, 0);


       // }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ghost")
       {
            b.gameObject.GetComponent<Renderer>().material.color = new Color(231, 82, 82, 0);
        }
    }
}
