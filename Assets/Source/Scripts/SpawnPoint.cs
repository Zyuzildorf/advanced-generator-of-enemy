using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;

    private Target _spawnedTarget;
    
    public void SpawnEnemy()
    {
        Debug.Log(_spawnedTarget);
        Instantiate(_enemy, transform.position, transform.rotation).GetTarget(_spawnedTarget);
    }

    private void Awake()
    {
        _spawnedTarget = Instantiate(_target, transform.position, transform.rotation);
    }
}