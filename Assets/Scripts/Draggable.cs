using UnityEngine;

public class Draggable : MonoBehaviour
{
    private float x;
    private float y;

    void Update()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
    }
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 1.0f));
    }
}
