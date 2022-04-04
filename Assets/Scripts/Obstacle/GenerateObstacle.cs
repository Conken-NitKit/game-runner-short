using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// ��Q���𐶐�����X�N���v�g
/// </summary>
public class GenerateObstacle : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private Transform playerTransform;

    [SerializeField] private float spawnPoint = 20;
    [SerializeField] private float spawnInterval;
    [SerializeField] private float obstaclePositionY = -4;

    private int randomNumber;

    private void Start()
    {
        StartCoroutine("SpawnObstacle");
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(playerTransform.position.x + spawnPoint, obstaclePositionY, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
