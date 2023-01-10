using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject[] spawnee;
    public Transform[] points;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee[Random.Range(0, 2)], points[Random.Range(0, 2)]);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
