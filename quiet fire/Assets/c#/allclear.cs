using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allclear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ghost")
        {
            SceneManager.LoadScene("final");
            value.clear = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
