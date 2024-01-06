using UnityEngine;

class CarMovement : MonoBehaviour

    
{
    [SerializeField] Rigidbody rb;

    [SerializeField] float forwardForce = 2000f;
    [SerializeField] float sidewaysForce = 500f;

    
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
