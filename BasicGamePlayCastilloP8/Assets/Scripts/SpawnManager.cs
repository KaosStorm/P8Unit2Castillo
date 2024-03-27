using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 25;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimals", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPreFabs.Length);
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPreFabs[animalIndex], spawnPos, animalPreFabs[animalIndex].transform.rotation);

    }
    void SpawnLeftAnimals() 
    {
        int animalIndex = Random.Range(0, animalPreFabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0); Instantiate(animalPreFabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal() { int animalIndex = Random.Range(0, animalPreFabs.Length); Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); Vector3 rotation = new Vector3(0, -90, 0); Instantiate(animalPreFabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); }
}

