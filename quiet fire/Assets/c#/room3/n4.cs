using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n4 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    public GameObject onion;
    public GameObject carrot;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onion.activeInHierarchy)
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
            carrot.SetActive(false);
        }
        else
        {
            oil.SetActive(true);
            meet.SetActive(true);
            onion.SetActive(true);
        }
    }
}
