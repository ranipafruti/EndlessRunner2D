using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2, 5.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        if(!GameManager.Instance.isGameOver)
        {
            int randomIndex = Random.Range(0, obstaclePrefabs.Length);

            Instantiate(obstaclePrefabs[randomIndex], transform.position, Quaternion.identity);

        }
    }
}
