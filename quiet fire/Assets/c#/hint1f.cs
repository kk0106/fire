using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint1f : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public float timer = 5;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            a.SetActive(false);
            b.SetActive(false);
        }
        else
        {
            if (timer >= 2.5)
            {
                a.SetActive(true);
                b.SetActive(false);
            }
            else
            {
                a.SetActive(false);
                b.SetActive(true);
            }
        }
    }
}
