using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの移動とジャンプを管理するクラス
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private float jumpPower;
    [SerializeField]private Rigidbody2D rb;

 private void FixedUpdate() {
    if(Input.GetKeyDown(KeyCode.Space)){
        rb.AddForce(transform.up * jumpPower);
    } 
    rb.velocity = new Vector2(speed, rb.velocity.y);      
  }
}
