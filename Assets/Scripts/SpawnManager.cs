using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 12;
    private float spawnZ = 20;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        Debug.Log(animalPrefabs.Length);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float positionX = Random.Range(-spawnRangeX, spawnRangeX);
        Debug.Log(animalIndex);
        Instantiate(animalPrefabs[animalIndex], new Vector3(positionX, 0, spawnZ), animalPrefabs[animalIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
