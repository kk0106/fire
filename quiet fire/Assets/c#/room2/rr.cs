using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rr : MonoBehaviour
{
    public GameObject dooor;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dooor.activeInHierarchy)
        {
            value.clear=2;
            return;
        }
    }
}
