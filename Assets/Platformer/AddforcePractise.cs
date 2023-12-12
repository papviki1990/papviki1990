using UnityEngine;

public class AddforcePractise : MonoBehaviour
{

    [SerializeField] float acceleration;
    [SerializeField] float speed;
    [SerializeField] float force;

    Vector3 clickLocalPosition;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMouseDown()
    {
        Camera cam = Camera.main;

        Vector3 clickGlobalPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        clickLocalPosition = transform.InverseTransformPoint(clickGlobalPosition);
    }

    void OnMouseDrag()
    {
        Camera cam = Camera.main;

        Vector3 mouseGlobalPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 clickGlobalPosition = transform.TransformPoint(clickLocalPosition);
        Vector3 movement = mouseGlobalPosition - clickGlobalPosition;
        Debug.Log($"On Drag: {movement}");

        // rb.velocity += (Vector2)movement.normalized * acceleration * Time.fixedDeltaTime;  // Gyorsul�s
        // rb velocity = (Vector2)movement.normalized * speed;  // Fix sebess�g
        rb.velocity += (Vector2)movement.normalized * acceleration / rb.mass * Time.fixedDeltaTime; // Er�

        rb.AddForceAtPosition(movement.normalized * force, clickGlobalPosition, ForceMode2D.Force);

    }
}
