using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintr3end : MonoBehaviour
{
    public GameObject tex;
    public float timer = 2;
    public GameObject pl;
    // Start is called before the first frame update
    void Start()
    {
        tex.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pl.activeInHierarchy)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                tex.SetActive(false);
            }
            else
            {
                tex.SetActive(true);
            }
        }
        
        
    }
}
