using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera[] cameras = new Camera[9];

    private void Start()
    {
        DisableAllCameras();
        ActivateCamera(0);  
    }

    private void Update()
    {
        CheckForCameraSwitch();
    }

    private void CheckForCameraSwitch()
    {
        for (int i = 1; i <= cameras.Length; i++) 
        {
            if (Input.GetKeyDown((KeyCode)KeyCode.Alpha0 + i) && cameras[i - 1] != null)
            {
                ActivateCamera(i - 1);  
            }
        }
    }

    private void ActivateCamera(int index)
    {
        DisableAllCameras();
        
        if (index < cameras.Length && cameras[index] != null)
        {
            cameras[index].gameObject.SetActive(true);  
        }
    }

    private void DisableAllCameras()
    {
        foreach (Camera cam in cameras)
        {
            if (cam != null)
            {
                cam.gameObject.SetActive(false);
            }
        }
    }
}
