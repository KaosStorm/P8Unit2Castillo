using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            SpawnRandomAnimals();
        }
        void SpawnRandomAnimals()
        {
            int animalIndex = Random.Range(0, animalPreFabs.Length);
            // Randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPreFabs[animalIndex], new Vector3(0, 0, 20), animalPreFabs[animalIndex].transform.rotation);
        }
    }
}
