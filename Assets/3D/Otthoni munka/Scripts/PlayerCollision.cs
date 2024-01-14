using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] CarMovement movement;
    private CarGameManager carGameManager;

    void Awake()
    {
        carGameManager = FindObjectOfType<CarGameManager>();
        if (carGameManager == null)
        {
            Debug.LogError("CarGameManager not found!");
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            if (carGameManager != null)
            {
                carGameManager.EndGame();
            }
        }
    }
}