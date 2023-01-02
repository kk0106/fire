using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room4 : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
   
    public GameObject doo;
    // Start is called before the first frame update
    void Start()
    {
        doo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a.activeInHierarchy && b.activeInHierarchy && c.activeInHierarchy )
        {
            doo.SetActive(true);
            value.clear = 3;
            return;
        }
        else
        {
            doo.SetActive(false);
        }
    }
}
