using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Teleport : MonoBehaviour
{
    [SerializeField] Material[] materials;
    [SerializeField] GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        ExitPortal();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "ARCamera")
        {
            return;
        }

        // Outside of portal
        if (transform.position.z > other.transform.position.z)
        {
            ExitPortal();
        }
        // Inside of Portal
        else
        {
            EnterPortal();
        }
    }

    void ExitPortal()
    {
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }

    void EnterPortal()
    {
        foreach (var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }

    private void OnDestroy()
    {
        EnterPortal();
    }
}
