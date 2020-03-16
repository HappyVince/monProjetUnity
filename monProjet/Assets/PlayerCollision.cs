using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMouvement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
