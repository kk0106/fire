using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paper : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionStay(Collision other)
    {

        if (other.gameObject.tag == "ghost")
        {
            a.SetActive(true);
            b.SetActive(true);
        }
        else
        {
            a.SetActive(false);
            b.SetActive(false);
        }
    }
}
