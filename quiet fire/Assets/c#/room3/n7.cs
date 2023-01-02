using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n7 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    public GameObject onion;
    public GameObject carrot;
    public GameObject garlic;
    public GameObject tomoto;
    public GameObject wine;
   
    public GameObject light;
    int a;
    // Start is called before the first frame update
    void Start()
    {
       
      light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (tomoto.activeInHierarchy)
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
        if (other.gameObject.tag == "1" && a == 1)
        {
            wine.SetActive(false);
          light.SetActive(true);
        }
        else
        {
            tomoto.SetActive(true);
            garlic.SetActive(true);
            oil.SetActive(true);
            meet.SetActive(true);
            onion.SetActive(true);
            carrot.SetActive(true);
        }
    }
}
