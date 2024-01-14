using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float forwardForce = 2000f;
    [SerializeField] float sidewaysForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(horizontalInput * sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<CarGameManager>().EndGame();
        }
    }
}