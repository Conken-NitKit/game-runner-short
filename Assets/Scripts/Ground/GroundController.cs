using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ɒn�ʂ������X�N���v�g
/// </summary>
public class GroundController : MonoBehaviour
{
    [SerializeField] private GameObject player; 

    void FixedUpdate()
    {
        if(this.transform.position.x + 10 < player.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
