using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass6 : MonoBehaviour
{
    public GameObject pointlight;
    public GameObject pointlight1;
    public GameObject pointlight2;
    public GameObject pointlight3;
    public GameObject pointlight4;
    public GameObject pointlight5;
    public GameObject door;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        pointlight5.SetActive(false);
        door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointlight.activeInHierarchy && pointlight1.activeInHierarchy && pointlight2.activeInHierarchy && pointlight3.activeInHierarchy&&pointlight4.activeInHierarchy)
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
            pointlight5.SetActive(true);
           door.SetActive(true);
        }
        if (a == 0)
        {
            pointlight.SetActive(false);
            pointlight1.SetActive(false);
            pointlight2.SetActive(false);
            pointlight3.SetActive(false);
            pointlight4.SetActive(false);
        }
    }
}
