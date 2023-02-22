using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public float spawnInterval = 1.0f;
    private float spawnRangeX = 2;
    private float spawnPosZ = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        while (true)
        {
            // Choose a random x position within the spawn range
            float xPos = Random.Range(-spawnRangeX, spawnRangeX);

            // Choose a random prefab from the options array
            int carIndex = Random.Range(0, carPrefabs.Length);

            // Create a new Vector3 for the spawn position
            Vector3 spawnPos = new Vector3(xPos, 0, spawnPosZ);

            // Instantiate the chosen prefab at the spawn position
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);

            // Wait for the specified spawn interval before spawning the next prefab
            yield return new WaitForSeconds(spawnInterval);
        }
    }









    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {   
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
            int carIndex = Random.Range(0, carPrefabs.Length);
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);

            Debug.Log("Spawn");
        }
    }
    */
}
