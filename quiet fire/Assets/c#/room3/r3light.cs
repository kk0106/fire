using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r3light : MonoBehaviour
{
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
        if (other.gameObject.tag == "fire")
        {
            pointlight.SetActive(true);
        }
    }
}
