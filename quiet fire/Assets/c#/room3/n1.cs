using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n1 : MonoBehaviour
{
    public GameObject oil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "1")
        {
            oil.SetActive(false);
        }
    }
}
