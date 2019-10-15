using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CMcontroller : MonoBehaviour
{
    public playerData pData;
    private CinemachineVirtualCamera vCamera;
    void Awake()
    {
        vCamera = GetComponent<CinemachineVirtualCamera>();
        pData.instanceAction = instanceHandler;
        pData.InstancePlayer();
    }

    private void instanceHandler(GameObject obj)
    {
        vCamera.Follow = obj.transform;
    }
}
