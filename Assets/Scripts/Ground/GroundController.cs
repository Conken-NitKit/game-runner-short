using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 主に地面を消すスクリプト
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
