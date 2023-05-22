using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;
    // public Transform playerTrans;
    // public Transform cam;
    bool isAlive = true;
    // public Rigidbody2D Ghost;

    public float PlayerForwardSpeedForce = 500f;
    public float CamMovementSpeed = 300f;
    public float GhostForwardSpeedForce = 600f;
    public float JumpForce = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Ghost.AddForce(new Vector2(GhostForwardSpeedForce * Time.deltaTime,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            player.AddForce(new Vector2(PlayerForwardSpeedForce * Time.deltaTime,0));
            // Ghost.AddForce(new Vector2(PlayerForwardSpeedForce * Time.deltaTime,0));
            // cam.position.x += (playerTrans.position.x + 9);
        }
    }

    public void jump()
    {
        if (isAlive)
        {
            player.AddForce(new Vector2(0,JumpForce));
        }
    }
}
