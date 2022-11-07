using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROOMSIXWIN : MonoBehaviour
{
    bool a;
    public GameObject door;
    public Vector3 v1;
    // Start is called before the first frame update
    void Start()
    {
       
        a = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "sofa")
        {
            a = true;
            
        }
        if(other.gameObject.name == "desk")
        {
            if (a == true)
            {
                Instantiate(door);
            }
        }
    }
    
}
