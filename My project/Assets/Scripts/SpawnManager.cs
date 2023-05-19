using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject powerup;
    float xSpawn = 10.0f;
    float zSpawn = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 1.0f);
        InvokeRepeating("SpawnPowerup", 1.0f, 10.0f);
        SpawnEnemy();
        SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        int randomvalue = Random.Range(0, enemies.Length);
        float zRandom = Random.Range(-zSpawn,zSpawn);
        Vector3 spawnpoint = new Vector3(xSpawn, 1.0f, zRandom);
        Instantiate(enemies[randomvalue], spawnpoint, Quaternion.identity);
    }

    void SpawnPowerup()
    {
        int randomvalue = Random.Range(0, enemies.Length);
        float zRandom = Random.Range(-zSpawn, zSpawn);
        float xRandom=Random.Range(-xSpawn, xSpawn);
        Vector3 spawnpoint = new Vector3(xRandom, 1.0f, zRandom);
        Instantiate(powerup, spawnpoint, Quaternion.identity);
    }
}
