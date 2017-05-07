using UnityEngine;

public class Interact : MonoBehaviour
{
    public RaycastHit2D Cast()
    {
        Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);

        return hit;
    }
}
