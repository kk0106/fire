using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text1 : MonoBehaviour
{
    public GameObject a;
    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        a.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a.activeInHierarchy)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            a.SetActive(false);
            Invoke("c", 1f);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ghost")
        {
            a.SetActive(true);
           
            
        }
        
    }
    private void c()
    {
        timer = 0.6f;
        return;
    }

}
