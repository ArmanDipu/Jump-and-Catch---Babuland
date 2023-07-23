using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public Rigidbody2D playerRigidbody2D;
    [SerializeField] private Transform landableChcek;
    [SerializeField] private LayerMask lanableLayer;
    public float jumpSpeed = 5f;
    public float moveSpeed = 5f;
    public FixedJoystick joystick;
    private float horizontalMove = 0f;

    private bool isLanded()
    {
        return Physics2D.OverlapCircle(landableChcek.position, 0.5f, lanableLayer);
    }

    private void Update()
    {
        horizontalMove = joystick.Horizontal * moveSpeed;
    }

    public void FixedUpdate()
    {
        playerRigidbody2D.velocity = new Vector2 (horizontalMove * moveSpeed, playerRigidbody2D.velocity.y);
    }


    public void jump()
    {
        if (isLanded())
        {
            playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpSpeed);
        }
    }
}
