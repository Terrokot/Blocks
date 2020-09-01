using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("We hit an obsticle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

