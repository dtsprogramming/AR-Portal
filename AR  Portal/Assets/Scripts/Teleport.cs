
using UnityEngine;
using UnityEngine.Rendering;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform device;

    bool wasInFront = false;
    bool inOtherWorld = false;

    // Start is called before the first frame update
    void Start()
    {
        SetMaterials(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform != device)
        {
            return;
        }

        wasInFront = GetIsInFront();
    }

    bool GetIsInFront()
    {
        Vector3 pos = transform.InverseTransformPoint(device.position);
        return pos.z >= 0 ? true : false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform != device)
        {
            return;
        }

        bool isInFront = GetIsInFront();

        if ((isInFront && !wasInFront) || (wasInFront && !isInFront))
        {
            inOtherWorld = !inOtherWorld;
            SetMaterials(inOtherWorld);
        }

        wasInFront = isInFront;
    }

    void SetMaterials(bool fullRender)
    {
        var stencilTest = fullRender ? CompareFunction.NotEqual : CompareFunction.Equal;
        Shader.SetGlobalInt("_StencilTest", (int)stencilTest);
    }

    private void OnDestroy()
    {
        SetMaterials(true);
    }
}
