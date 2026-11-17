using UnityEngine;

public class FinalTimer : RunTimer
{

    public TMPro.TextMeshProUGUI finalTimerTextMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FinalTime();
    }

    public void FinalTime()
    {
        currentTime = timeValue;
        finalTimerTextMeshPro.text = "Final Time: " + currentTime.ToString("F2");
    }
}
