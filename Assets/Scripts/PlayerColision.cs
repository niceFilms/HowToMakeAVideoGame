using UnityEngine;

public class PlayerColision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstical")
        {
            movement.enabled = false;
        }
    }

}
