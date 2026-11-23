using UnityEngine;

public class ScaleWithScreen : MonoBehaviour
{
    //set reference resolution and initial scale
    public Vector2 referenceResolution = new Vector2(1920, 1080);
    private Vector3 initialScale;

    void Start()
    {
        //change scale at start if needed
        initialScale = transform.localScale;
        UpdateScale();
    }

    void Update()
    {
        // Check if screen size changed
        if (Screen.width != lastWidth || Screen.height != lastHeight)
        {
            UpdateScale();
        }
    }

    private int lastWidth, lastHeight;

    void UpdateScale()
    {
        //update the scale based on current screen resolution
        float scaleFactor = (float)Screen.width / referenceResolution.x;
        transform.localScale = initialScale * scaleFactor;

        lastWidth = Screen.width;
        lastHeight = Screen.height;
    }
}