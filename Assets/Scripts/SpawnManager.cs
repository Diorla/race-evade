using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnZ = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(animalPrefabs.Length);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            float positionX = Random.Range(-spawnRangeX, spawnRangeX);
            Debug.Log(animalIndex);
            Instantiate(animalPrefabs[animalIndex], new Vector3(positionX, 0, spawnZ), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
