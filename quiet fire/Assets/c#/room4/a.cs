using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public GameObject img;
    public GameObject b;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (img.activeInHierarchy)
        {
            timer -= Time.deltaTime;
           
        }
        
        if (timer <= 10)
        {
            b.SetActive(true);
        }
        if (timer <= 0)
        {
            b.SetActive(false);
        }
    }
}
