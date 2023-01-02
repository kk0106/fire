using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n5 : MonoBehaviour
{
    public GameObject oil;
    public GameObject meet;
    public GameObject onion;
    public GameObject carrot;
    public GameObject garlic;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (carrot.activeInHierarchy)
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
            garlic.SetActive(false);
        }
        else
        {
            oil.SetActive(true);
            meet.SetActive(true);
            onion.SetActive(true);
            carrot.SetActive(true);
        }
    }
}
