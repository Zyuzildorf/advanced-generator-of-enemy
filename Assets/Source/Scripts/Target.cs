using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 7f;

    private List<Vector3> _waypoints;
    private Vector2 _minMaxWaipointValues = new Vector2(-47, 47);
    private int _currentWaypoint;

    private void Awake()
    {
        SetRandomWaypoints();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _waypoints[_currentWaypoint])
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Count;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint],
            _moveSpeed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(_waypoints[_currentWaypoint]);
    }

    private void SetRandomWaypoints()
    {
        _waypoints = new List<Vector3>();
        _waypoints.AddRange(new Vector3[]
        {
            GetRandomPosition(),GetRandomPosition(),GetRandomPosition(),
            GetRandomPosition(),GetRandomPosition()
        });
            
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 randomPosition = new Vector3(GetRandomValue(), 0,
            GetRandomValue());

        return randomPosition;
    }

    private float GetRandomValue()
    {
        float randomValue = Random.Range(_minMaxWaipointValues.x, _minMaxWaipointValues.y);

        return randomValue;
    }
}