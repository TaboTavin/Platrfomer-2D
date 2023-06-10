using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float jumpForce = 5f;
    public float playerSpeed = 5f;
    public LayerMask groundMask;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }
  
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        PlayerMovement();
    }

    void Jump()
    {
     
    }

    void PlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0);
        playerRB.AddForce(movement * playerSpeed);
    }

}
