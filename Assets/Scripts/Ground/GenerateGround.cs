using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �n�ʂ������Ő�������X�N���v�g
/// �v���C���[�̈ꂩ��x��spawnChecker����ɐ��������
/// </summary>
public class GenerateGround : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject player;

    [SerializeField] private float spawnPoint = 10;
    [SerializeField] private float spawnChecker = 20;
    [SerializeField] private float groundPositionY = -5;

    void FixedUpdate()
    {
        if(player.transform.position.x > spawnPoint - spawnChecker)
        {
            Instantiate(ground, new Vector3(spawnPoint, groundPositionY, 0), Quaternion.identity);
            spawnPoint += 10;
        }
    }
}
