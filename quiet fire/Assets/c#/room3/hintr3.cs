using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintr3 : MonoBehaviour
{
    public GameObject a;
    public static float  timer=30;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }
   
    // Update is called once per frame
    void Update()
    {
      
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            if (timer <= 2)
            {
                a.SetActive(true);
            }
        }
    }
}
