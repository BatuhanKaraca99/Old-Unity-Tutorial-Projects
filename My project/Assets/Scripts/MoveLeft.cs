using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    Rigidbody enemy;
    float speed = 4.5f;
    float xBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemy=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.AddForce(Vector3.left * speed);
        if (transform.position.x < xBound)
        {
            Destroy(gameObject);
        }
    }
}
