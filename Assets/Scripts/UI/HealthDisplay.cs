using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _healthDisplay;

    private void OnEnable()
    {
        _player.HealthChaged += onHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChaged -= onHealthChanged;
    }

    private void onHealthChanged(int health)
    {
        _healthDisplay.text = health.ToString();
    }
}
