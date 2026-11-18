using UnityEngine;

public class NoteRhythm : MonoBehaviour
{
    public static NoteRhythm Instance;
    public double hitBeat;

    private bool wasHit;

    public bool WasHit => wasHit;

    public void Hit()
    {
        wasHit = true;

        Destroy(gameObject);
    }

    private void Update()
    {
        double currentBeat =
            Manager.Instance.SongPositionInBeats;

        if (!wasHit && currentBeat > hitBeat + 0.3)
        {
            Debug.Log("MISS");

            Destroy(gameObject);
        }
    }
}
