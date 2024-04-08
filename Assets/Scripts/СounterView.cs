using System.Collections;
using TMPro;
using UnityEngine;

public class —ounterView : MonoBehaviour
{
    [SerializeField] private float _timeStep;
    [SerializeField] private float _incrementStep;
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textCounter;

    private bool _isCounting = false;
    private Coroutine _countingCoroutine;

    public void ClickButton()
    {
        if (_isCounting)
            StopCoroutine(_countingCoroutine);

        _isCounting = !_isCounting;

        if (_isCounting)
            _countingCoroutine = StartCoroutine(—ounteUp(_timeStep, _incrementStep));
    }

    private IEnumerator —ounteUp(float timeStep, float incrementStep)
    {
        var wait = new WaitForSecondsRealtime(timeStep);

        while (_isCounting)
        {
            _counter.Increase(incrementStep);
            Disply—ounte();

            yield return wait;
        }              
    }

    private void Disply—ounte()
    {
        _textCounter.text = (_counter.CurrentValue).ToString("");
    }
}