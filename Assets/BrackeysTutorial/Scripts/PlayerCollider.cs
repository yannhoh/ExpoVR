
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    public Player movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }  
    
    }


}
