using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n6 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    public GameObject onion;
    public GameObject carrot;
    public GameObject garlic;
    public GameObject tomoto;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (garlic.activeInHierarchy)
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
            tomoto.SetActive(false);
        }
        else
        {
            garlic.SetActive(true);
            oil.SetActive(true);
            meet.SetActive(true);
            onion.SetActive(true);
            carrot.SetActive(true);
        }
    }
}
