using UnityEngine;

public class DownwardAccelerator : MonoBehaviour
{
    [SerializeField] float acceleration = 9.81f; // Be�ll�that� gyorsul�s �rt�k

    float speed = 0f;

    void Update()
    {
        // Gyorsul�s hozz�ad�sa a sebess�ghez
        speed += acceleration * Time.deltaTime;

        // Az objektum lefel� mozgat�sa a sebess�g alapj�n
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Ha el�rte a 0 magass�got, �lljon meg
        if (transform.position.y <= 0f)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
            speed = 0f;
        }
    }

    /* using UnityEngine;    Ez is j�

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
