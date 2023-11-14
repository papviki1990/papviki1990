
using UnityEngine;

class PathMover : MonoBehaviour

  
    
    {
    [SerializeField] Transform t1, t2;
    [SerializeField, Range(0,1)] float startPoint;
    [SerializeField] float speed;

    Transform currentTarget;

    private void Start()
    {
        currentTarget = t2;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
             transform.position,
            currentTarget.position,
            speed * Time.deltaTime);

        if(transform.position == t2.position)
        {
            currentTarget = t1;
        }
        if (transform.position == t1.position)
        {
            currentTarget = t2;
        }
    }


    private void OnValidate()
    {
        transform.position =

        transform.position = Vector3.Lerp(t1.position, t2.position, startPoint);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;
        
        Gizmos.DrawWireSphere(p1, 0.25f);
        Gizmos.DrawWireSphere(p2, 0.25f);
        Gizmos.DrawLine(p1, p2);
    }
}
