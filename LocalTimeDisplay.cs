using System;
using UnityEngine;
using TMPro;

public class LocalTimeDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro timeText;

    private void Start()
    {
        if (timeText == null)
        {
            Debug.LogError("TextMeshPro component is not assigned to LocalTimeDisplay script!");
            return;
        }

        UpdateTimeText();
        InvokeRepeating(nameof(UpdateTimeText), 1f, 1f);
    }

    private void UpdateTimeText()
    {
        DateTime localTime = DateTime.Now;
        string formattedTime = localTime.ToString("HH:mm:ss");

        timeText.text = "Local Time: " + formattedTime;
    }
}
