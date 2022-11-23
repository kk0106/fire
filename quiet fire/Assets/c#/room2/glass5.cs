using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass5 : MonoBehaviour
{
    public GameObject pointlight;
    public GameObject pointlight1;
    public GameObject pointlight2;
    public GameObject pointlight3;
    public GameObject pointlight4;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        pointlight4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (pointlight.activeInHierarchy && pointlight1.activeInHierarchy && pointlight2.activeInHierarchy&&pointlight3.activeInHierarchy)
        {
            a = 1;
        }
        else
        {
            a = 0;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "fire" && a == 1)
        {
            pointlight4.SetActive(true);
            // door2.SetActive(true);
        }
        if (a == 0)
        {
            pointlight.SetActive(false);
            pointlight1.SetActive(false);
            pointlight2.SetActive(false);
            pointlight3.SetActive(false);
        }
    }
}
