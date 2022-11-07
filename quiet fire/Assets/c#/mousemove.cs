using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mousemove : MonoBehaviour
{
    // public Vector3 v1;
    //  public Vector3 v2;

    Material material;

    // Start is called before the first frame update
    private void Start()
    {
        //  v1 = GetComponent<Vector3>();
        // v2=GetComponent<Vector3>();
        material = GetComponent<Material>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit1;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "canmove")
                {
                    Vector3 mousePosition = new Vector3(0,0,5);
                    hit.transform.position = mousePosition;
                    // v1 = hit.collider.transform.position;
                    //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    // hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                }
                if (hit.collider.gameObject.tag == "canmove1")
                {
                    Vector3 mousePosition = new Vector3(10, 1, 40);
                    hit.transform.position = mousePosition;

                }

                if (hit.collider.gameObject.tag == "canmove2")
                {
                    Vector3 mousePosition = new Vector3(-15, 1, -20);
                    hit.transform.position = mousePosition;
                }

                if (Physics.Raycast(ray, out hit1))
                {
                    if (hit1.collider.gameObject.tag == "1")
                    {
                        //Vector3 mousePosition = new Vector3(Input.mousePosition.x, 0 , 0);
                        // hit1.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                        // hit1.transform.position = v1;
                        //v2 = hit1.collider.transform.position;
                        //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                        //hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                        // hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    }
                    else
                    {
                        Debug.Log("nothing");
                    }

                }
            }
        }
    }
}

    

