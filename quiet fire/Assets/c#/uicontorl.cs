using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uicontorl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void quit()
    {
        Application.Quit();
    }
    public void start()
    {
        SceneManager.LoadScene("how to play");
    }
    public void credit()
    {
        SceneManager.LoadScene("credit");
    }
    public void play()
    {
        SceneManager.LoadScene("story");
    }

    public void playgame()
    {
        SceneManager.LoadScene("1f");
    }
   
}
