using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] KeyCode key = KeyCode.Space;
    [SerializeField] GameObject bulletPrototype;
    private void Update()
    {
        if(Input.GetKeyDown(key))
        {
            GameObject newBullet = 
                Instantiate(bulletPrototype, transform.position, transform.rotation);
        }
    }
}
