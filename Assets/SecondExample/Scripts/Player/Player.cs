using UnityEngine;
using Zenject;

public class Player : MonoBehaviour, IEnemyTarget
{
    private int _maxHealth;
    private int _health;

    public Vector3 Position => transform.position;

    [Inject]
    public void Construct(PlayerStatsConfig config)
    {
        _health = _maxHealth = config.MaxHealth;
        Debug.Log($"У меня {_health} хп");
    }

    public void TakeDamage(int damage)
    {
        //проверка урона

        Debug.Log($"Получил {damage} урона");
    }
}
