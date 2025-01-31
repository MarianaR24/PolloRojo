using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Fungus;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public bool play = false; 
    public Flowchart dialogo;
    
    void Start()
    {
        
    }

    void Update()
    {
        play = dialogo.GetBooleanVariable("Video");

        if(play)
        {
            videoPlayer.Play();
        }
    }
}
