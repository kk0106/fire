using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour
{
    public GameObject door;
    public GameObject plight;
    public GameObject plight1;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (plight.activeInHierarchy&&plight1.activeInHierarchy)
        {
            door.SetActive(true);
        }   
    }

}
