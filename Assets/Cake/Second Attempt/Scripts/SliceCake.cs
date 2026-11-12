using UnityEngine;

public class SliceCake : MonoBehaviour
{
    public float perfectWindow = 0.05f;
    public float goodWindow = 0.10f;
    public float missWindow = 0.20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckInput();
        }
    }

    void CheckInput()
    {
        NoteRhythm[] notes =
            FindObjectsOfType<NoteRhythm>();

        NoteRhythm closest = null;

        double smallestDifference =
            double.MaxValue;

        double currentBeat =
            Manager.Instance.SongPositionInBeats;

        foreach (NoteRhythm note in notes)
        {
            double difference =
                System.Math.Abs(currentBeat - note.hitBeat);

            if (difference < smallestDifference)
            {
                smallestDifference = difference;
                closest = note;
            }
        }

        if (closest == null)
            return;

        if (smallestDifference <= perfectWindow)
        {
            Debug.Log("PERFECT");
            closest.Hit();
        }
        else if (smallestDifference <= goodWindow)
        {
            Debug.Log("GOOD");
            closest.Hit();
        }
        else if (smallestDifference <= missWindow)
        {
            Debug.Log("BAD");
            closest.Hit();
        }
    }
}
