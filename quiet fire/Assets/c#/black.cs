using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class black : MonoBehaviour
{
    public float timer = 1;
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
            SceneManager.LoadScene("1f");
            Invoke("Reset", 2f);
        }
    }

    private void Reset()
    {
        timer = 1;
    }
}
