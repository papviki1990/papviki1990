using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] Transform target;


    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;


        Vector3 directionVector = targetPosition - selfPosition;

        Quaternion targetRotation = Quaternion.LookRotation(directionVector);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);


    }
}



