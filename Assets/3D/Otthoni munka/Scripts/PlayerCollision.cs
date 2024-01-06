using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    [SerializeField] CarMovement movement;

  void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
