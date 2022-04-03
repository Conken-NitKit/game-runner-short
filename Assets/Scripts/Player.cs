using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの移動とジャンプを管理するクラス
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Animator animator;
    private bool isGround;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(transform.up * jumpPower);
        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            animator.SetBool("Obstacle", true);
            animator.SetBool("ObstacleJump", true);
            speed = 0;

            Debug.Log("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GameOver")
        {
            Debug.Log("GameOver");
        }
    }
}
