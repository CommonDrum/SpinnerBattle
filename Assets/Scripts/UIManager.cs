using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text speedText;

    private void OnEnable()
    {
        GameEvents.OnSpeedChanged.AddListener(UpdateSpeedText);
    }

    private void OnDisable()
    {
        GameEvents.OnSpeedChanged.RemoveListener(UpdateSpeedText);
    }

    private void UpdateSpeedText(float speed)
    {
        if (speedText != null)
        {
            speedText.text = $"Speed: {speed}";
        }
        else
        {
            Debug.LogError("Speed Text element not assigned in UIManager!");
        }
    }
}
