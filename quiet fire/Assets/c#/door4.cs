using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door4 : MonoBehaviour
{
    public GameObject doorr4;
    public GameObject texr4;
    public float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        
        texr4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
        if (doorr4.activeInHierarchy)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                
                texr4.SetActive(false);
            }
            else
            {
                texr4.SetActive(true);
            }
        }
    }
}
