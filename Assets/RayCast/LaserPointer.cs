using UnityEditor.SceneManagement;
using UnityEngine;

class LaserPointer : MonoBehaviour
{
    [SerializeField] Transform[] inBetweenPoints;
    [SerializeField] LayerMask rayCastMask;
    [SerializeField] float maxDistance = 100;


    private void Update()
    {
        Vector3 startPoint = transform.position;
        Ray ray = new Ray(transform.position, transform.forward);


        bool isHit = Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, rayCastMask);

        if (isHit)
        {
            Vector3 endPoint = hit.point;
            Vector3 step = endPoint - startPoint;
            step /= inBetweenPoints.Length - 1;
            
            foreach(Transform t in inBetweenPoints)
            {
                t.position = startPoint;
                startPoint += step;
            }
        }

        foreach (Transform t in inBetweenPoints)
            t.gameObject.SetActive(isHit);

    }

    void OnEnable()
    {
        Debug.Log("Enabled");
    }

    void OnDisable()
    {
        Debug.Log("Disabled");
    }

    void Start()
    {
        Debug.Log("Started");
    }

    void Awake()
    {
        Debug.Log("Awaken");
    }

    void OnDestroy()
    {
        Debug.Log("Destroyed");
    }

    void LateUpdate()
    {

    }
}
