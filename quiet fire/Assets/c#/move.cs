using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private CharacterController character;
    public Transform cam;

    public float speed = 7f;

    public float turnSmoothTime = 0.1f;


    float turnSmoothVelocity;

    // Start is called before the first frame update
    void Start()
    {
        character = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0f, Vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg+cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnSmoothVelocity,turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetangle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            character.Move(moveDir.normalized * speed * Time.deltaTime);
        }


    }
}
