using UnityEngine;

public class MovementPractise : MonoBehaviour
{


    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Fix Velocity
        Vector3 velocity = Vector3.right * 10;

        rb.velocity = velocity;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Fix Velocity Change

            Rigidbody rb = GetComponent<Rigidbody>();


            Vector3 velocityChange = Vector3.up * 2;

            rb.velocity += velocityChange;

            // rb.AddForce(velocityChange, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            // Fix Impulse Change

            Rigidbody rb = GetComponent<Rigidbody>();


            Vector3 impulseChange = Vector3.up * 2;

            rb.velocity += impulseChange / rb.mass;

            // rb.AddForce(velocityChange, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        // Fix gyorsulás
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 acceleration = Vector3.down * 2;

            rb.velocity += acceleration * Time.fixedDeltaTime;

            // rb.AddForce(velocityChange, ForceMode.Acceleration);
        }

        // Fix erõt közlünk
        
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 acceleration = Vector3.down * 2;

            rb.velocity += acceleration * Time.fixedDeltaTime / rb.mass;

            // rb.AddForce(acceleration);
        }
    }


}
