using UnityEngine;

// This script was copied over from Tom's Timer Script, I just want to add my events without affecting Tom's minigame.
public class PlatformerTimer : MonoBehaviour
{
    [SerializeField] private float timeValue;
    [SerializeField] private TMPro.TextMeshProUGUI timerTextMeshPro;

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            PlatformerSystem.onGameStateChange?.Invoke(false);
        }

        DisplayTimer(timeValue);

    }

    private void DisplayTimer(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Calculating Minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Calculating Seconds
        timerTextMeshPro.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Displaying the Timer in Text Format by Minutes / Seconds / Minutes / Seconds
    }
}
