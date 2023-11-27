using UnityEngine;

public class DownwardAccelerator : MonoBehaviour
{
    [SerializeField] float acceleration = 5f; // Be�ll�that� gyorsul�s �rt�k

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
}
