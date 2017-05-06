using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
