using UnityEngine;
using UnityEngine.UIElements;

public class MusicManager : MonoBehaviour
{
    [Header("Music")]
    public AudioSource musicSource;
    public float bpm = 87f;
    public int beatsPerBar = 3;

    [Header("Hit Windows")]
    public float perfectWindow = 0.1f;
    public float goodWindow = 0.25f;

    [Header("Material")]
    private Material originalMaterial;
    public Material perfectMaterial;
    public Material goodMaterial;
    public Material badMaterial;
    private Renderer circleRenderer;
    
    // Rhythm map (beat positions)
    // 0 = first beat of song
    // 1 = second beat
    // 1.5 = offbeat
    // etc.
    public float[] noteBeats =
    {
        0f,
        0.1f,
        0.2f,


        0.3f,
        0.4f,
        0.5f,
        1f,


        2f,
        3f,
        4f,

        5f,
        6.5f,
        7f,

        8f,
        9f,
        10f,

        11f,
        12.5f,
        13f,

        14f,
        15f,
        16f,

        17f,
        18f,

        20f,
        21.5f,
        22f,

        23f,
        24f,
        25f,

        26f,

        29f,


    };
   
    

    private float[] noteTimes;
    private int nextHitNote = 0;
    

    void Start()
    {
        GenerateNoteTimes();

        circleRenderer = GetComponent<Renderer>();
        originalMaterial = circleRenderer.material;
    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckHit();
        }
    }

    void GenerateNoteTimes()
    {
        float secondsPerBeat = 60f / bpm;
        
        noteTimes = new float[noteBeats.Length];

        for (int i = 0; i < noteBeats.Length; i++)
        {
            noteTimes[i] = noteBeats[i] * secondsPerBeat;
            
        }
    }

    

    void CheckHit()
    {
        if (nextHitNote >= noteTimes.Length)
            return;

        float currentTime = musicSource.time;

        float difference =
            Mathf.Abs(currentTime - noteTimes[nextHitNote]);

        if (difference <= perfectWindow)
        {
            Debug.Log("PERFECT!");
            nextHitNote++;

            circleRenderer.material = perfectMaterial;
            Invoke("ResetMaterial", 0.2f);
        }
        else if (difference <= goodWindow)
        {
            Debug.Log("GOOD!");
            nextHitNote++;
            circleRenderer.material = goodMaterial;
            Invoke("ResetMaterial", 0.2f);
        }
        else
        {
            Debug.Log("MISS!");
            circleRenderer.material = badMaterial;
            Invoke("ResetMaterial", 0.2f);
        }
    }

    void ResetMaterial()
    {
        circleRenderer.material = originalMaterial;
    }
}