using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;

    public float ForwardSpeedForce = 500f;
    public float JumpForce = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.AddForce(new Vector2(ForwardSpeedForce * Time.deltaTime,0));

        if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(new Vector2(0,JumpForce));
        }
    }
}
