using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Target _target;
    private Vector3 _moveDirection;

    public void GetTarget(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, 
            _moveSpeed * Time.deltaTime);
        transform.LookAt(_target.transform);
    }
}