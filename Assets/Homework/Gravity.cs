using UnityEngine;

public class DownwardAccelerator : MonoBehaviour
{
    [SerializeField] float acceleration = 5f; // Beállítható gyorsulás érték

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
}
