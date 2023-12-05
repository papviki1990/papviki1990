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



        /* Ez is jó
         
         using UnityEngine;

class Rocket : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] float speed = 5;
        [SerializeField] float angularSpeed = 180;

        void Update()
        {
            Vector3 targetPoint = target.position;

            Vector3 targetDir = targetPoint - transform.position;
            Quaternion targetRot = Quaternion.LookRotation(targetDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, angularSpeed * Time.deltaTime);

            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }*/

}
}



