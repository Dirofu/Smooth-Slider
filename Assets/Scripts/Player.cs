using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _damage;

    public event UnityAction<int> HealthChanged;

    public void Damage()
    {
        _health -= _damage;
        HealthChanged?.Invoke(_health);
    }

    public void Heal()
    {
        _health += _damage;
        HealthChanged?.Invoke(_health);
    }
}
