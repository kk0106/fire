using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooooe : MonoBehaviour
{
    public GameObject pointlight;
    public GameObject dooor;
    // Start is called before the first frame update
    void Start()
    {
        dooor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointlight.activeInHierarchy)
        {
            dooor.SetActive(true);
        }
    }
}
