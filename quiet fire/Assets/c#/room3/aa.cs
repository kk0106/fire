using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aa : MonoBehaviour
{
    public GameObject plight;
    // Start is called before the first frame update
    void Start()
    {
        plight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "fire")
        {
            plight.SetActive(true);
        }
    }
}
