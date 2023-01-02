using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text2 : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
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
        }
        else
        {
            a.SetActive(false);
        }
    }
}
