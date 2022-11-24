using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    bool a;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "booktest")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo>().scenename);
        }
        if (other.gameObject.name == "door")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo0>().scenename);
        }
        if (other.gameObject.name == "goto6-2")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo1>().scenename);
        }
        if (other.gameObject.name == "goto6-1")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo2>().scenename);
        }
        if (other.gameObject.name == "gotobook")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo3>().scenename);
        }
        if (other.gameObject.name == "gotoroom")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo4>().scenename);
        }
        if (other.gameObject.name == "gotoffice")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo5>().scenename);
        }
        if (other.gameObject.name == "room1")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo6>().scenename);
        }
        if (other.gameObject.name == "room2")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo7>().scenename);
        }
        if (other.gameObject.name == "room3")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo8>().scenename);
        }
        if (other.gameObject.tag == "room1")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo9>().scenename);
        }
        if (other.gameObject.tag == "doorroom4")
        {
            SceneManager.LoadScene(other.gameObject.GetComponent<sceneinfo10>().scenename);
        }
       
    }
}
