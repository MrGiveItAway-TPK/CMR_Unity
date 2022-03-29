using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public PlayerMovment player_movement;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag=="Obstacle")
        {
            player_movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
