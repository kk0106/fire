using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform playerobj;
    //public Transform crosshair;
    public Rigidbody rb;
    public float roarspeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewDir =player.position- new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 inputdir = orientation.forward* Vertical +orientation.right * Horizontal;
       
         
        if (inputdir != Vector3.zero)
        {
            playerobj.forward = Vector3.Slerp(playerobj.forward, inputdir, Time.deltaTime * roarspeed);
        }
    }
}
