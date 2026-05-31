using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private Transform aPoint;
    [SerializeField] private Transform bPoint;
    [SerializeField] private Transform cPoint;
    [SerializeField] private Transform dPoint;

    [SerializeField] private int waveNumber;
    [SerializeField] private List<Wave> waves;

    [System.Serializable]
    public class Wave
    {
        public ObjectPooler pool;
        public float timer;
        public float spawnInterval;
        public int objectPerWave;
        public int objectSpawnedCount;
    }

    void Update()
    {
        waves[waveNumber].timer += Time.deltaTime;
        if(waves[waveNumber].timer >= waves[waveNumber].spawnInterval)
        {
            SpawnObject();
            waves[waveNumber].timer -= waves[waveNumber].spawnInterval;
            if (waves[waveNumber].objectSpawnedCount >= waves[waveNumber].objectPerWave)
            {
                waves[waveNumber].objectSpawnedCount = 0;
                waveNumber++;
                if (waveNumber >= waves.Count)
                {
                    waveNumber = 0;
                }
            }
        }
    }
    private void SpawnObject()
    {
        GameObject spawnObject = waves[waveNumber].pool.GetPooledObject();
        spawnObject.transform.position = RandomSpawnPoint();
        spawnObject.SetActive(true);
        waves[waveNumber].objectSpawnedCount++;
    }
    private Vector2 RandomSpawnPoint()
    {
        int rad = Random.Range(0, 4);
        Vector2 spawnPoint;

        if (rad == 0)
        {
            spawnPoint.x = Random.Range(aPoint.position.x, bPoint.position.x);
            spawnPoint.y = Random.Range(aPoint.position.y, bPoint.position.y);
        }
        else if (rad == 1)
        {
            spawnPoint.x = Random.Range(cPoint.position.x, dPoint.position.x);
            spawnPoint.y = Random.Range(cPoint.position.y, dPoint.position.y);
        }
        else if (rad == 2)
        {
            spawnPoint.x = Random.Range(aPoint.position.x, cPoint.position.x);
            spawnPoint.y = Random.Range(aPoint.position.y, cPoint.position.y);
        }
        else
        {
            spawnPoint.x = Random.Range(bPoint.position.x, dPoint.position.x);
            spawnPoint.y = Random.Range(bPoint.position.y, dPoint.position.y);
        }

        return spawnPoint;
    }
}
