using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float randomz = 0.0f;
    private float randomx = 0.0f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BallSpawn", 1.0f,3.0f);
    }

    private void Update()
    {
    }

    void BallSpawn()
    {
        randomz = Randomizer();
        randomx = Randomizer();
        Instantiate(ball, new Vector3(randomx, 3.17f, randomz), Quaternion.identity);
    }

    float Randomizer()
    {
        float random = Random.Range(0, 1);
        return random;
    }
}
