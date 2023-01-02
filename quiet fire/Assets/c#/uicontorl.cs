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
        value.clear = 0;
    }
    public void credit()
    {
        SceneManager.LoadScene("credit");
    }
    public void play()
    {
        SceneManager.LoadScene("story");
        value.clear = 0;
    }

    public void playgame()
    {
        SceneManager.LoadScene("black");
    }
   public void back()
    {
        SceneManager.LoadScene("start");
        value.clear = 0;
    }
    public void menu()
    {
        SceneManager.LoadScene("start");
        value.clear = 0;
    }
  
}
