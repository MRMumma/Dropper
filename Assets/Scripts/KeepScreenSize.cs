using UnityEngine;

public class KeepScreenSize : MonoBehaviour
{
    //sets the camera and the object units
    public Camera mainCamera;
    public float objectSizeInWorldUnits = 1f;

    void LateUpdate()
    {
        //gets camera position information
        float distance = Vector3.Distance(mainCamera.transform.position, transform.position);
        float frustumHeight = 2.0f * distance * Mathf.Tan(mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad);
        float scale = objectSizeInWorldUnits / frustumHeight;
        transform.localScale = Vector3.one * scale;
    }
}