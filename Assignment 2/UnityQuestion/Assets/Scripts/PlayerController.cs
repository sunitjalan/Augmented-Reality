using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    const int moveSpeed = 10;
    Rigidbody player;
    const float jumpForce=7.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        player.velocity = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, player.velocity.y, Input.GetAxis("Vertical")*moveSpeed);
        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector3(player.velocity.x, jumpForce, player.velocity.z);
        }
    }
}
