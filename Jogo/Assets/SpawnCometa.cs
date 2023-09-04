using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCometa : MonoBehaviour
{
    public GameObject cometa;
    float timer = 0.0f; 
    int cometasSpawnados = 0; 
    public int limiteCometas = 10; 

    void Update()
    {
        
        timer += Time.deltaTime;

        
        if (timer >= 0.2f && cometasSpawnados < limiteCometas)
        {
            Vector2 position = new Vector2(transform.position.x, Random.Range(-4.5f, 4.5f));

            
            Instantiate(cometa, position, Quaternion.identity);

            
            timer -= 0.2f;

            
            cometasSpawnados++;
        }
    }
   
}
