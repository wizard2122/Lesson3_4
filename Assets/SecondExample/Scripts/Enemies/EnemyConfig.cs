using System;
using UnityEngine;

[Serializable]
public class EnemyConfig
{
    [SerializeField] private Enemy _prefab;
    [SerializeField, Range(1, 10)] private int _health;
    [SerializeField, Range(1, 10)] private float _speed;

    public Enemy Prefab => _prefab;
    public int Health => _health;
    public float Speed => _speed;
}
