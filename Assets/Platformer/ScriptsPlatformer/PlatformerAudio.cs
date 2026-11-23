using UnityEngine;

public class PlatformerAudio : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource walkSound;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpSound.Play();

    }
}
