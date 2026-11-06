using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;

    public double[] chart =
    {
        4,
        6,
        8,
        10,
        12,
        14,
        16
    };

    private int nextNote;

    private void Update()
    {
        if (nextNote >= chart.Length)
            return;

        double currentBeat =
            Manager.Instance.SongPositionInBeats;

        if (currentBeat >= chart[nextNote] - 4)
        {
            SpawnNote(chart[nextNote]);

            nextNote++;
        }
    }

    void SpawnNote(double beat)
    {
        GameObject note =
            Instantiate(notePrefab);

        note.GetComponent<NoteRhythm>().hitBeat =
            beat;
    }
}
