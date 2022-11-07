using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt : MonoBehaviour
{

    
    
    Material material;

    // Start is called before the first frame update
    private void Start()
    {
        
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
                if (hit.collider.gameObject.tag == "book")
                {
                    Vector3 mousePosition = new Vector3(Input.mousePosition.x,Input.mousePosition.y , 0);
                }
                else
                {
                    Debug.Log("nothing");
                }

            }
           
        }
    }


}
