using UnityEngine;
using Cinemachine;

public class SwitchCamera : MonoBehaviour
{
    private CinemachineVirtualCamera TPSCam;
    private void Start()
    {
        TPSCam = GameObject.Find("TPS Cam").GetComponent<CinemachineVirtualCamera>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
                TPSCam.Priority *= -1;
        }
    }
}
