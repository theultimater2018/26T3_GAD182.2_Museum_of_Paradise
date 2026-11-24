using System.Collections;
using UnityEngine;

public class SpriteShake : MonoBehaviour
{
    public float shakeDuration = 0.2f;
    public float shakeAmount = 0.1f;

    private Vector3 originalPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        originalPosition = transform.position;

        float elapsed = 0f;

        while (elapsed < shakeDuration)
        {
            float offsetX = Random.Range(-shakeAmount, shakeAmount);
            float offsetY = Random.Range(-shakeAmount, shakeAmount);

            transform.position = originalPosition + new Vector3(offsetX, offsetY, 0);

            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = originalPosition;
    }
}
