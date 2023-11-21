using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 25f;
    [SerializeField] float destroyDistance = 10;

    Vector3 startPoint;

    void Start()
    {
        startPoint = transform.position;
    }

    void Update()
    {
        // Mozg�s
        Vector3 globalDir = transform.up;
        transform.position += globalDir * speed * Time.deltaTime;

        // Elpuszt�t�s
        Vector3 point = transform.position;
        bool isOutOufRange = Vector3.Distance(point, startPoint) > destroyDistance;
        if (isOutOufRange)
            Destroy(gameObject);
    }
}
