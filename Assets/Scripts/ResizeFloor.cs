using UnityEngine;

public class ResizeFloor : MonoBehaviour
{
    public GameObject floorObject;
    Vector3 resize;

    void Start()
    {
        //resizes the floor based on screens width and height
        floorObject = GameObject.Find("Floor");
        resize.x = Screen.width;
        resize.y = Screen.height / 20;
        floorObject.transform.localScale = resize;
    }
}
