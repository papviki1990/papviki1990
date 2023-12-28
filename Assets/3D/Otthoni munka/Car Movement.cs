using UnityEngine;

class PlayerMovement : MonoBehaviour

    
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
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }
}
