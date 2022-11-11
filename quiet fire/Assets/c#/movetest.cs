using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 10f;
    public float rotspeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        controller=transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movelikewow();
       // Vector3 move= new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //characterController.Move(move * Time.deltaTime * speed);
    }
    private void movelikewow()
    {
        var Horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");

        var move1 = transform.forward * speed *Vertical* Time.deltaTime;
        controller.Move(move1);

        transform.Rotate(Vector3.up, Horizontal * rotspeed);
    }
}
