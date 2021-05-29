using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class cameraCont : MonoBehaviour
{
    public GameObject plr;
    private CinemachineVirtualCamera vCamera;
    void Awake()
    {
        vCamera = GetComponent<CinemachineVirtualCamera>();
    }

    void update ()
    {
        vCamera.Follow = plr.transform;
    }
}
