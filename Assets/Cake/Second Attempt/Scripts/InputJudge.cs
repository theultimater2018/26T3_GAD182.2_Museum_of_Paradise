using UnityEngine;

public class InputJudge : MonoBehaviour
{
    public double targetBeat = 4;

    bool judged;

    void Update()
    {
        if (judged)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            double currentBeat =
                Manager.Instance.SongPositionInBeats;

            double difference =
                System.Math.Abs(currentBeat - targetBeat);

            if (difference < 0.1)
            {
                Debug.Log("PERFECT");
            }
            else if (difference < 0.25)
            {
                Debug.Log("GOOD");
            }
            else
            {
                Debug.Log("MISS");
            }

            judged = true;
        }
    }
}
