using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass2 : MonoBehaviour
{
    public GameObject pointlight;
    public GameObject pointlight1;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        pointlight1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointlight.activeInHierarchy)
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
        if (other.gameObject.tag == "fire"&& a==1)
        {
            pointlight1.SetActive(true);
        }
        if (a == 0)
        {
            pointlight.SetActive(false);
        }
    }
}
