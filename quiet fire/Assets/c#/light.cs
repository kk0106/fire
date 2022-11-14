using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
   // Vector3 v1;
    public GameObject b;
    public GameObject pointlight;
    
    

    // Start is called before the first frame update
    void Start()
    {
        pointlight.SetActive(false);
       // v1 = b.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(KeyCode.F))
       // {

         //   b.gameObject.GetComponent<Renderer>().material.color = new Color(231, 82, 82, 0);


       // }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "1")
       {
           // b.gameObject.GetComponent<Renderer>().material.color = new Color(0,0,10,10);
            pointlight.SetActive(true);
        }
        else
        {
            Debug.Log("none");
        }
    }
}
