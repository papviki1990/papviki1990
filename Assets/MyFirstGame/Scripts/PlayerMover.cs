using UnityEngine;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Transform cameraTransform;

    [SerializeField] Damageable damageable;

    private void OnValidate()
    {
        if (damageable == null)
            damageable = GetComponent<Damageable>();
    }

    void Update()
    {
        bool isDead = damageable.GetCurrentHealth() <= 0;
        if (isDead) return;

        // Transform t = transform;

        // t.position = new Vector3(0, 10, 0);
        // t.position = t.position + velocity;

        // bool upInput = Input.GetKey(KeyCode.W);

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        // Vector3 inputVector = new Vector3(x,0,z);

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 inputVector = x * cameraRight + z * cameraForward;
        inputVector.y = 0;
       
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
