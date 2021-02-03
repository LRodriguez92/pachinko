using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public LifeTracker lifeTracker;
    public float spawnHeight;
    
    private int maxAmountOfSpawns;

    void Start()
    {
        maxAmountOfSpawns = lifeTracker.lives;
    }

    void Update()
    {
        maxAmountOfSpawns = lifeTracker.lives;
    }

    public void SpawnPrefab()
    {
        maxAmountOfSpawns -= 1;

        if (maxAmountOfSpawns >= 0) 
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn) as GameObject;

            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            spawnPosition.z = prefabToSpawn.transform.position.z;

            spawnPosition.y = spawnHeight;

            spawnedObject.transform.position = spawnPosition;
            
        }
        else
        {
            Debug.Log("Prefab reached the max amount of spawns!");
        }
    }

    public int GetNumSpawned()
    {
        return maxAmountOfSpawns;
    }

}
