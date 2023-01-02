using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintr4start : MonoBehaviour
{
    public float timer = 2;
    public GameObject a;
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
        }
    }
}
