using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    public static int b;
    // Start is called before the first frame update
    void Start()
    {
        b = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backroom3()
    {
        SceneManager.LoadScene("room3");
    }
    public void backroom4()
    {
        SceneManager.LoadScene("room4");
        b = 1;
        return;
    }
}
