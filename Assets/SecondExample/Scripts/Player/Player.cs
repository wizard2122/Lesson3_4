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
        Debug.Log($"� ���� {_health} ��");
    }

    public void TakeDamage(int damage)
    {
        //�������� �����

        Debug.Log($"������� {damage} �����");
    }
}
