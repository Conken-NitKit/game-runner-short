using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 障害物を生成するスクリプト
/// </summary>
public class GenerateObstacle : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private GameObject player;

    [SerializeField] private float spawnPoint = 20;
    [SerializeField] private float spawnChecker = 10;
    [SerializeField] private float obstaclePositionY = -4;

    private int randomNumber;

    void FixedUpdate()
    {
        if (player.transform.position.x > spawnPoint - spawnChecker)
        {
            randomNumber = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[randomNumber], new Vector3(spawnPoint, obstaclePositionY, 0), Quaternion.identity);
            
        }
    }
}
