using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uicontorl1 : MonoBehaviour
{
    public Transform player;
    public Transform image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image.eulerAngles = new Vector3(0, 0, -player.eulerAngles.y);
        image.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }
}
