using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpawnPortal : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;

    private Animator anim;
    private Transform tf;

    void Start()
    {
        anim = GetComponent<Animator>();
        tf = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        
    }

    public void RaisePortal()
    {
        anim.SetBool("isPlaced", true);
        videoPlayer.SetDirectAudioMute(0, false);
    }
}
