using UnityEngine;

class AirJumpMotifier : MonoBehaviour
{

    [SerializeField] bool removeJumps = false;
    [SerializeField] bool deleteOnContact = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // PlatformerController pc = collision.GetComponent<PlatformerController>();

        if (collision.TryGetComponent(out PlatformerController pc))
        {
            if (removeJumps) ;
            // pc.RemoveJumpBudget();
            else
                pc.FillJumpBudget();

            if (deleteOnContact)
                Destroy(gameObject);
        }
    }
}
