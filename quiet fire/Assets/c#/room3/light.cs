using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l : MonoBehaviour
{
    public GameObject pl;
    // Start is called before the first frame update
    void Start()
    {
        pl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "fire")
        {
            pl.SetActive(true);
        }
    }
}
