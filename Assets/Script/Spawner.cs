using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPrefabs; 
    [SerializeField] private float spawnInterval;  
    [SerializeField] private Transform spawnPoint;     
    
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }



    void Update()
    {
        
    }

    private IEnumerator SpawnRoutine()
    {
        while (!GameManager.Instance.isGameOver) 
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnObject()
    {
        int randomIndex = Random.Range(0, spawnPrefabs.Length); 
        Instantiate(spawnPrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
    }
}
