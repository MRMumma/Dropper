using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

public class ObjectsAnchor : MonoBehaviour
{
    public enum AnchorSide {Left, Right, Top, Bottom, FloorStretch}
    public AnchorSide anchorSide;

    private Camera mainCamera;
    private Rigidbody2D rb;
    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        PositionObject();
    }

    void PositionObject()
    {
        //moves the position of the object to the edge of the screen
        Vector3 pos = transform.position;

        if (anchorSide == AnchorSide.Left)
        {
            pos.x = mainCamera.ViewportToWorldPoint(new Vector3(0, 0.5f, 0)).x;
        }

        else if (anchorSide == AnchorSide.Right)
        {
            pos.x = mainCamera.ViewportToWorldPoint(new Vector3(1, 0.5f, 0)).x;
        }

        else if (anchorSide == AnchorSide.Top)
        {
            pos.y = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 1, 0)).y;
        }

        else if (anchorSide == AnchorSide.Bottom)
        {
            pos.y = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0, 0)).y;
        }

        else if (anchorSide == AnchorSide.FloorStretch)
        {
            Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
            Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

            float worldWidth = topRight.x - bottomLeft.x;
            float worldHeight = topRight.y - bottomLeft.y;

            transform.localScale = new Vector3(worldWidth, worldHeight, 1);
            pos = new Vector3 (0, 0, transform.position.z);
        }

        if (rb != null)
        {
            rb.MovePosition(pos);
        }

        else
        {
            transform.position = pos;
        }

    }
}
