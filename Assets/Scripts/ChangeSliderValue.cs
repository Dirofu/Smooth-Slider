using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Slider))]

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;
    private float _nextValue;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _nextValue = _slider.value;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _nextValue, .5f);
    }

    private void OnHealthChanged(int health)
    {
        _nextValue = health;
    }
}
