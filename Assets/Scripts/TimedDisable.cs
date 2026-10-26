using UnityEngine;

public class TimedDisable : MonoBehaviour
{
    [SerializeField] private float _maxLifeTime;

    private float _timeLeft;

    // ------------------------------------------------------------------------
    private void OnEnable ()
    {
        _timeLeft = _maxLifeTime;
    }

    // ------------------------------------------------------------------------
    private void Update()
    {
        _timeLeft -= Time.deltaTime;
        if(_timeLeft <= 0.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
