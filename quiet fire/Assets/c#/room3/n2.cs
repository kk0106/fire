using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n2 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oil.activeInHierarchy)
        {
            a = 0;
        }
        else
        {
            a = 1;

        }
    }
    private void OnCollisionEnter(Collision other)
    {
       
            if (other.gameObject.tag == "1"&&a==1)
            {
                meet.SetActive(false);
            }
        
       
        else
        {
            oil.SetActive(true);
        }
    }
}
