using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc : MonoBehaviour
{
    public GameObject escpanel;
    // Start is called before the first frame update
    void Start()
    {
        escpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            escpanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void keep()
    {
        escpanel.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
