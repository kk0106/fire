using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fstory : MonoBehaviour
{
    public GameObject a;
   // public GameObject b;
    public GameObject c;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
       // b.SetActive(false);
        c.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            a.SetActive(false);
           // b.SetActive(true);
            c.SetActive(true);
        }
     
    }
}
