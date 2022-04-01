using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �n�ʂ��v���C���[�ƐڐG�����ۂɗ�����悤�ɂ���X�N���v�g
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
