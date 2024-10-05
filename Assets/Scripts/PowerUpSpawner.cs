using System.Collections;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    public float spawnInterval = 10f; 

    void Start()
    {
        StartCoroutine(SpawnPowerUpRoutine());
    }

    IEnumerator SpawnPowerUpRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            int randomIndex = Random.Range(0, powerUpPrefabs.Length);
            Vector2 spawnPosition = new Vector2(Random.Range(-7, 7), Random.Range(-4, 4));

            Instantiate(powerUpPrefabs[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}
