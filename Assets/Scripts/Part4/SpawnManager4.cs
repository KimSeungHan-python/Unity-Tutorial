using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager4 : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnPos = 9.0f;

    private int enemyCount = 3;

    public GameObject powerupPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemy(enemyCount);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length == 0)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
            enemyCount++;
            SpawnEnemy(enemyCount);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPointX = Random.Range(-spawnPos, spawnPos);
        float spawnPointZ = Random.Range(-spawnPos, spawnPos);
        Vector3 randomPos = new Vector3(spawnPointX, 0, spawnPointZ);
        return randomPos;
    }

    void SpawnEnemy(int enemyCount)
    {
        for(int i=0; i<enemyCount; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
