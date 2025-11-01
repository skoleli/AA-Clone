using UnityEngine;
using Unity.Mathematics;

public class ForceQuaternionIdentity : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.rotation = quaternion.identity;
    }
}