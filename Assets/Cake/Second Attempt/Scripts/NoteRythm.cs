using UnityEngine;

public class NoteRhythm : MonoBehaviour
{
    public float targetBeat;

    void Update()
    {
        float currentBeat = Manager.Instance.GetCurrentBeat();

        if (currentBeat >= targetBeat + 1)
        {
            Destroy(gameObject);
        }
    }
}
