using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float Radius = 1;
    public float spawnTime = 0f;
    public float randomRate = 0f;

    public GameObject Enemy;
    private float spawnTimeEnemy= 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > spawnTime)
        {
            SpawnObject();
        }
        if (Time.time > spawnTimeEnemy)
        {
            SpawnEnemy();
        }
    }

    void SpawnObject()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;
        Instantiate(ItemPrefab, randomPos, Quaternion.identity);

        spawnTime = Time.time + randomRate;
        Debug.Log(Time.time + randomRate);
    }
    void SpawnEnemy()
    {
        Vector3 randomPos1 = Random.insideUnitCircle * 4;
        Instantiate(Enemy, randomPos1, Quaternion.identity);

        spawnTimeEnemy = Time.time + 5;
        Debug.Log(Time.time + 5);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
