using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{

    public GameObject missilePrefab;
    public float radiusOfSpawning = 5f;
    public float spawnRate = 1f;
    private float nextSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextSpawn += Time.deltaTime;
        if (nextSpawn > spawnRate)
        {
            nextSpawn = 0f;
            GameObject missile = Instantiate(missilePrefab,(transform.position + new Vector3(Random.Range(-radiusOfSpawning, radiusOfSpawning), Random.Range(-radiusOfSpawning,radiusOfSpawning), 0f)),Quaternion.identity);

        }
    }
}
