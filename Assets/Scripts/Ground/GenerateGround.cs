using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �n�ʂ������Ő�������X�N���v�g
/// �v���C���[�̈ʒu����x��spawnChecker����ɐ��������
/// </summary>
public class GenerateGround : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject fallGround;

    [SerializeField] private float spawnPoint = -10;
    [SerializeField] private float spawnChecker = 20;
    [SerializeField] private float groundPositionY = -5;

    private int randomNumber;
    void FixedUpdate()
    {
        if(player.transform.position.x > spawnPoint - spawnChecker)
        {
            randomNumber = Random.Range(0, 21);
            if(randomNumber == 10)
            {
                Instantiate(fallGround, new Vector3(spawnPoint, groundPositionY, 0), Quaternion.identity);
                spawnPoint += 1;
            }
            else
            {
                Instantiate(ground, new Vector3(spawnPoint, groundPositionY, 0), Quaternion.identity);
                spawnPoint += 1;
            }
            
        }
    }
}
