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
    public GameObject tex;
    public GameObject tex2;

    public float timer = 2;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        pointlight5.SetActive(false);
        door.SetActive(false);
        tex.SetActive(false);
        tex2.SetActive(false);
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
        if (pointlight5.activeInHierarchy)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                tex.SetActive(false);
                tex2.SetActive(false);
            }
            else
            {
                if (timer <= 3)
                {
                    tex.SetActive(false);
                    tex2.SetActive(true);
                }
            }
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "1" && a == 1)
        {
            pointlight5.SetActive(true);
           door.SetActive(true);
            tex.SetActive(true);
            tex2.SetActive(false);
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
