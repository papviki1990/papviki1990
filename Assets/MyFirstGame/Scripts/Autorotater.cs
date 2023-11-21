using UnityEngine;

using UnityEngine;

class AutoRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360; //Szögsebesség
    [SerializeField] Space space = Space.Self;

    
        
    

    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0, space);
    }
}
