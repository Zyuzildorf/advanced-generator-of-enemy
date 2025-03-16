using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemyInSpawnPoint), 0.0f, _repeatRate);
    }

    private void SpawnEnemyInSpawnPoint()
    {
        ChooseRandomSpawnPoint().SpawnEnemy();
    }

    private SpawnPoint ChooseRandomSpawnPoint()
    {
        SpawnPoint spawnPoint;

        spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

        return spawnPoint;
    }
}