using UnityEngine;

public class NoteMover : MonoBehaviour
{
    public Transform hitPoint;
    public float travelBeats = 4f;

    private NoteRhythm note;

    private Vector3 startPosition;

    private void Awake()
    {
        note = GetComponent<NoteRhythm>();

        startPosition = transform.position;
    }

    private void Update()
    {
        double currentBeat =
            Manager.Instance.SongPositionInBeats;

        float progress =
            (float)((currentBeat -
                     (note.hitBeat - travelBeats))
                     / travelBeats);

        transform.position =
            Vector3.Lerp(startPosition,
                         hitPoint.position,
                         progress);
    }
}
