using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n3 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    public GameObject onion;
    int a;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (meet.activeInHierarchy)
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
        if (other.gameObject.tag == "fire" && a == 1)
        {
            onion.SetActive(false);
        }
        else
        {
            oil.SetActive(true);
            meet.SetActive(true);
        }
    }
}
