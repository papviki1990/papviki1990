using UnityEngine;

public class DownwardAccelerator : MonoBehaviour
{
    [SerializeField] float acceleration = 9.81f; // Beállítható gyorsulás érték

    float speed = 0f;

    void Update()
    {
        // Gyorsulás hozzáadása a sebességhez
        speed += acceleration * Time.deltaTime;

        // Az objektum lefelé mozgatása a sebesség alapján
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Ha elérte a 0 magasságot, álljon meg
        if (transform.position.y <= 0f)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
            speed = 0f;
        }
    }

    /* using UnityEngine;    Ez is jó

class Gravity : MonoBehaviour
{
    [SerializeField] float acceleration = 9.81f;

    float speed = 0;

    void Update()
    {
        if (transform.position.y <= 0)
        {
            Vector3 p = transform.position;
            p.y = 0;
            transform.position = p;
            speed = 0;
        }
        else 
        {        
            speed += acceleration * Time.deltaTime;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
} */

}
