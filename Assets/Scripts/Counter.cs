using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _currentValue;

    public float CurrentValue => _currentValue;

    public void Increase(float incrementStep)
    {
        _currentValue += incrementStep;
    }
}