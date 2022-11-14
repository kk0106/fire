using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotcross : MonoBehaviour
{
    public GameObject shootcross;
    public GameObject shootimage;
    // Start is called before the first frame update
    void Start()
    {
        shootcross.SetActive  (false);
        shootimage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            shootcross.SetActive(true);
            shootimage.SetActive(true);
        }
        else
        {
            shootimage.SetActive(false);
        }
    }
    

}
