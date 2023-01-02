using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finnaltex : MonoBehaviour
{
    public GameObject tex;
    // Start is called before the first frame update
    void Start()
    {
        tex.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "ghost")
        {
            tex.SetActive(true);
        }
        else
        {
            tex.SetActive(false);
        }
       
    }

}
