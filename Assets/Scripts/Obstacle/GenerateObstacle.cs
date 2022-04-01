using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 障害物を生成するスクリプト
/// </summary>
public class GenerateObstacle : MonoBehaviour
{
    [SerializeField] private GameObject obstacle1;
    [SerializeField] private GameObject obstacle2;
    [SerializeField] private GameObject obstacle3;
    [SerializeField] private GameObject player;

    [SerializeField] private float spawnPoint = 20;
    [SerializeField] private float spawnChecker = 10;
    [SerializeField] private float obstaclePositionY = -4;

    private int randomNumber;
    [SerializeField] private int obstacleAmount;

    void FixedUpdate()
    {
        if (player.transform.position.x > spawnPoint - spawnChecker)
        {
            randomNumber = Random.Range(0, obstacleAmount + 1);
            switch (randomNumber)
            {
                case 0:
                    Instantiate(obstacle1, new Vector3(spawnPoint, obstaclePositionY, 0), Quaternion.identity);
                    spawnPoint += 10;
                    break;
                case 1:
                    Instantiate(obstacle2, new Vector3(spawnPoint, obstaclePositionY, 0), Quaternion.identity);
                    spawnPoint += 10;
                    break;
                case 2:
                    Instantiate(obstacle2, new Vector3(spawnPoint, obstaclePositionY, 0), Quaternion.identity);
                    break;
                default:
                    break;
            }
            
        }
    }
}
