using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;

    private float spawnRangeX = 3.7f;
    private float spawnPosZ = 100f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int carIndex = Random.Range(0, carPrefabs.Length);
            Instantiate(carPrefabs[carIndex], new Vector3(0, 0, 50), carPrefabs[carIndex].transform.rotation);
        }
    }
}
