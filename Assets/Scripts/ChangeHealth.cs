using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class ChangeHealth : MonoBehaviour
{
    [SerializeField] private float _step;

    private Slider _slider;
    private float _nextValue;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _nextValue = _slider.value;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _nextValue, .5f);
    }

    public void Damage()
    {
        _nextValue = _slider.value - _step;
    }

    public void Heal()
    {
        _nextValue = _slider.value + _step;
    }
}
