using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SpawnPortal : MonoBehaviour
{
    [SerializeField]
    GameObject[] portalActivation;

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
        foreach (GameObject gameObject in portalActivation)
        {
            gameObject.SetActive(true);
        }
    }
}
