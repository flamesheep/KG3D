using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public int aniIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomAnimal()
    {
        
        aniIndex = Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[aniIndex], new Vector3(Random.Range(-15, 15), 0, 20),
            animalPrefab[aniIndex].transform.rotation);
        
    }
}
