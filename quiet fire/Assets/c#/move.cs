using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   
    public float speed = 5f;
    public float rotate = 7f;
    float rotateMultiplier = 1f;
  
    Rigidbody rb;
    Animator ani;
    Vector3 moveamount;
    // Start is called before the first frame update
    void Start()
    {
      
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

        Vector3 movedir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        moveamount = movedir * speed * Time.deltaTime;

        Quaternion targetRot = Quaternion.FromToRotation(transform.forward, movedir) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotate * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveamount);
    }



}
