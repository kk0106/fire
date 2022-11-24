using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class value : MonoBehaviour
{
    public static int clear;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (door.activeInHierarchy)
        {
            clear = 1;
        }
    }
}
