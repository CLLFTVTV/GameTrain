using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] blocks;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.8f, spawnPosZ);

        //Instantiate(animalPrefabs, spawnPos, animalPrefabs[animalIndex].transform.rotation);

        blocks = new GameObject[animalPrefabs.Length]; //makes sure they match length

        for (int i = 0; i < animalPrefabs.Length; i++)
        {
            blocks[i] = Instantiate(animalPrefabs[i], spawnPos, animalPrefabs[animalIndex].transform.rotation) as GameObject;
        }

        Destroy(animalPrefabs[animalIndex]);
    }
}
