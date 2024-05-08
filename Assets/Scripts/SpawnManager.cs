using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] animalPrefabs;

    //Bonus Feature - Medium Extra
    [SerializeField]
    GameObject[] sideAnimals;
    //

    [SerializeField]
    float spawnPosX = 10;
    [SerializeField]
    float spawnPosZ = 20;

    //Bonus-Feature-Medium
    [SerializeField]
    float sideSpawnX = 22;
    [SerializeField]
    float sideSpawnZ = 10;
    //

    [SerializeField]
    float startDelay = 2;
    [SerializeField]
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //Bonus Feature - Medium
        InvokeRepeating("SpawnSideLeftRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnSideRightRandomAnimal", startDelay, spawnInterval);
        //
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    //Bonus Feature - Medium
    void SpawnSideLeftRandomAnimal()
    {
        int animalFarmIndex = Random.Range(0, sideAnimals.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnZ + 5, sideSpawnZ - 5));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(sideAnimals[animalFarmIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnSideRightRandomAnimal()
    {
        int animalFarmIndex = Random.Range(0, sideAnimals.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnZ + 5, sideSpawnZ - 5));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(sideAnimals[animalFarmIndex], spawnPos, Quaternion.Euler(rotation));
    }
    //
}
