using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        InvokeRepeating("RotateCube", Random.Range(0.0f, 1.0f), Random.Range(0.0f, 2.0f));
        transform.localScale = new Vector3(Random.Range(1,5), Random.Range(1, 5), Random.Range(1, 5));
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    void RotateCube()
    {
        transform.Rotate(Random.Range(0, 2) * Time.deltaTime, 0.0f, Random.Range(0, 2));
    }
}
