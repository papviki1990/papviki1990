using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed;

    void Update()
    {
        // Transform t = transform;

        // t.position = new Vector3(0, 10, 0);
        // t.position = t.position + velocity;

        // bool upInput = Input.GetKey(KeyCode.W);

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 inputVector = new Vector3(x,0,z);
       
        if (inputVector != Vector3.zero)
        {
            inputVector.Normalize();
            Vector3 velocity = inputVector * speed;
            transform.position += velocity * Time.deltaTime;

            Quaternion targetRotation = Quaternion.LookRotation(inputVector);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                angularSpeed * Time.deltaTime);
        }

    }
}
