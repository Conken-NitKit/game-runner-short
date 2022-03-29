using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Q���𐶐�����X�N���v�g
/// </summary>
public class GenerateObstacle : MonoBehaviour
{
    [SerializeField] private GameObject needle;
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject player;

    [SerializeField] private float spawnPoint = 20;
    [SerializeField] private float spawnChecker = 10;
    [SerializeField] private float obstaclePositionY = -4;

    private float randomNumber;

    void FixedUpdate()
    {
        randomNumber = Random.value * 5;
        if(player.transform.position.x > spawnPoint - spawnChecker)
        {
            switch (randomNumber)
            {
                case 0:
                    obstaclePositionY -= 0.5;
                    for (int i = 1; i < 0;i++,obstaclePositionY += 0.5)
                    {
                        Instatiate(needle, new Vector3(spawnPoint, obstaclePositionY, 0), Quaternion.identity);
                    }
                        
                    spawnPoint += 3;
                    break;
            }
        }
        
    }
}
