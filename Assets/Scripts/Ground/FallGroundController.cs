using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 地面がプレイヤーと接触した際に落ちるようにするスクリプト
/// </summary>
public class FallGroundController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;

    [SerializeField] private float speed;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb2D.velocity = new Vector3(0, -speed, 0);
        }
        
    }
}
