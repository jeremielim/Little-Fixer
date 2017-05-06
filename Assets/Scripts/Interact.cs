using UnityEngine;

public class Interact : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Cast().transform != null)
            {
                if (Cast().transform.name == "Thorn")
                {
                    if (Cast().transform.gameObject.GetComponent<Rigidbody2D>() == null)
                    {
                        Cast().transform.gameObject.AddComponent<Rigidbody2D>();
                    }
                }
            }
        }
    }

    public RaycastHit2D Cast()
    {
        Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.zero, 0f);

        return hit;
    }
}
