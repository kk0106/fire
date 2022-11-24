using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class video : MonoBehaviour
{
    VideoPlayer playvideo = new VideoPlayer();
    public GUI UI;
    // Start is called before the first frame update
    void Start()
    {
        playvideo = GetComponent<VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
