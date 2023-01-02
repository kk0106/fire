using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("r1");
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("r2");
        }
    }
}
