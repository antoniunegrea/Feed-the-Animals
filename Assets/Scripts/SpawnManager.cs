using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float xRange = 9.0f;
    public float spawnPozZ = 17.0f;
    private float startDelay = 3;
    private float spawnInterval = 1.8f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPoz = new Vector3(Random.Range(-xRange, xRange), 0, spawnPozZ);
        Instantiate(animalPrefab[animalIndex], spawnPoz, animalPrefab[animalIndex].transform.rotation);
    }
}
