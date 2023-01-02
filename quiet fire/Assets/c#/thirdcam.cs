using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdcam : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform ghost;
    public Rigidbody rig;

    public float rotspeed;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    private void Update()
    {
        Vector3 viewDir = player.position - new Vector3(transform.position.x, transform.position.y, transform.position.z);
        orientation.forward = viewDir;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;


        if(inputDir != Vector3.zero)
        {
            ghost.forward = Vector3.Slerp(ghost.forward, inputDir.normalized, Time.deltaTime * rotspeed);
        }
    }
}
