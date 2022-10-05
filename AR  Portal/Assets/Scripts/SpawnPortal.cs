using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpawnPortal : MonoBehaviour
{
    [SerializeField] GameObject videoPlayer;
    [SerializeField] GameObject particles;
    [SerializeField] GameObject portalWindow;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void DropPortal()
    {
        anim.SetBool("isPlaced", true);
    }

    void ActivatePortal()
    {
        particles.SetActive(true);
        portalWindow.SetActive(true);
        videoPlayer.SetActive(true);
    }
}
