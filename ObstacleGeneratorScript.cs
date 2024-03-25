using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneratorScript : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private float obstacleSpeed = 5f;
    [SerializeField] private Transform playerPosition;

    private float nextSpawnTime;

    private void Start()
    {
        // Spawn the first obstacle when the script starts
        SpawnObstacle();
    }

    private void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        // Instantiate the obstacle at the spawn point
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);

        Rigidbody2D obstacleRb = obstacle.GetComponent<Rigidbody2D>();
        obstacleRb.velocity = new Vector2(-obstacleSpeed, 0f);

        // Destroy the obstacle after a certain time
        StartCoroutine(DestroyObstacle(obstacle));
    }

    private IEnumerator DestroyObstacle(GameObject obstacle)
    {
        // Wait until the obstacle passes a certain point (adjust the position as needed)
        // while (obstacle != null && obstacle.transform.position.x > playerPosition.transform.position.x + 10f)
        // {
        //     yield return null;
        // }

        // Check if the obstacle still exists before destroying it
        if (obstacle != null)
        {
            //if the player passes the obstacle destroy the object
            if(playerPosition.transform.position.x > obstaclePrefab.transform.position.x + 10f)
            {
                Destroy(obstacle,5f);
            }
        }
        yield return null;
    }

}
