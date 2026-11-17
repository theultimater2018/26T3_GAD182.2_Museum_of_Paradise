using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DelayedIntroText : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float delay = 0.1f;
    private string fullText;
    private string currentText = "Escape The Toxic Waste! RUN RUN RUN ";
    public GameObject heldTimer;

    void Start()
    {
        fullText = textComponent.text;
        StartCoroutine(LateText());
    }

    IEnumerator LateText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textComponent.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            heldTimer.SetActive(false);
        }
    }
}