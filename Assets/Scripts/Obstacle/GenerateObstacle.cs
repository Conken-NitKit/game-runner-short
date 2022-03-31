using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 障害物を生成するスクリプト
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
        
    }
}
