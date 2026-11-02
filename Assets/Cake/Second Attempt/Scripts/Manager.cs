using UnityEngine;

public class Manager : MonoBehaviour
{

    public float bpm = 120f;

    public static Manager Instance;

    public float SecondsPerBeat => 60f / bpm;

    private float songStartTime;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        songStartTime = Time.time;
    }

    public float GetSongTime()
    {
        return Time.time - songStartTime;
    }

    public float GetCurrentBeat()
    {
        return GetSongTime() / SecondsPerBeat;
    }
}
