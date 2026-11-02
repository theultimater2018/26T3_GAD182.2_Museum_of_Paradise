using UnityEngine;

public class InputJudge : MonoBehaviour
{
    public float targetBeat = 8f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentBeat = Manager.Instance.GetCurrentBeat();

            float difference = Mathf.Abs(currentBeat - targetBeat);

            if (difference < 0.1f)
            {
                Debug.Log("Perfect!");
            }
            else if (difference < 0.25f)
            {
                Debug.Log("Good!");
            }
            else
            {
                Debug.Log("Miss!");
            }
        }
    }
}
