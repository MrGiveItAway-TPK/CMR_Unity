using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody player_rb;
    public float forward_force = 2000f;
    public float left_right_force = 500f;
    void FixedUpdate()
    {
        player_rb.AddForce(0,0,forward_force * Time.deltaTime);

        if(player_rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        int i = 0;
        while (i<Input.touchCount)
        {
            if (Input.GetTouch(i).position.x>Screen.width/2)
            {
                player_rb.AddForce(left_right_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetTouch(i).position.x < Screen.width / 2)
            {
                player_rb.AddForce(-left_right_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            ++i;
        }

        
        if (Input.GetKey("d"))
        {
            player_rb.AddForce(left_right_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            player_rb.AddForce(-left_right_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
