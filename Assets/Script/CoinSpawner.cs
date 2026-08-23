using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefabs;
    [SerializeField] private float gap;
    [SerializeField] private int totalcoin;   
    [SerializeField] private float coinTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());

    }

    IEnumerator Spawner()
    {
        while (true)
        {
            SpawnCoins();
            yield return new WaitForSeconds(coinTime);
        }

    }
    void SpawnCoins()
    { 
        for(int i=0; i < totalcoin; i++)
        {
            Vector3 pos = new Vector3(transform.position.x + i * gap, transform.position.y, 0f);
            Instantiate(coinPrefabs, pos, Quaternion.identity); 
        }
    }

}
