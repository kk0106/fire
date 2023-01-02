using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lll : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (key.y == 1)
        {
            a.SetActive(true);
        }
        if (keypad.ll == 1)
        {
            a.SetActive(false);
        }
    }
}
