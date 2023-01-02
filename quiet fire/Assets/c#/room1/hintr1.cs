using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintr1 : MonoBehaviour
{
    public GameObject a;
   // public GameObject b;
    public float timer =30;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    //    b.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 5)
        {
           
            if (timer <= 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                if (timer >= 2.5)
                {
                    a.SetActive(true);
                   // b.SetActive(false);
                }
                else
                {
                    a.SetActive(false);
                   // b.SetActive(true);
                }
            }
        }
        
    }
}
