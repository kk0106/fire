using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyfire : MonoBehaviour
{
    public float second;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGameObject", second);
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
