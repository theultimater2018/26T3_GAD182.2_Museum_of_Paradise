using UnityEngine;

public class Manager : MonoBehaviour
{

    public static Manager Instance;

    [Header("Song")]
    public AudioSource musicSource;
    public float bpm = 120f;

    private double songStartTime;
    private double secondsPerBeat;

    public double SongPositionInSeconds
    {
        get
        {
            return AudioSettings.dspTime - songStartTime;
        }
    }

    public double SongPositionInBeats
    {
        get
        {
            return SongPositionInSeconds / secondsPerBeat;
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        secondsPerBeat = 60.0 / bpm;

        double startTime = AudioSettings.dspTime + 1.0;

        musicSource.PlayScheduled(startTime);

        songStartTime = startTime;
    }
}
