using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooor : MonoBehaviour
{
    public GameObject dor;
    public GameObject pointlight;
    // Start is called before the first frame update
    void Start()
    {
        dor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointlight.activeInHierarchy)
        {
            dor.SetActive(true);
        }
    }
}
