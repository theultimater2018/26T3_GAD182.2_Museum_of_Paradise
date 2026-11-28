using UnityEngine;

public class PlatformerAudio : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound; 
    [SerializeField] private AudioSource splashSound;
    [SerializeField] private AudioSource walkSound;
    
    private void PlayJumpSound()
    {
        jumpSound.Play();
    }

    private void PlayDamageSounds()
    {
        splashSound.Play();
    }

    private void PlayMoveSound()
    {
        walkSound.Play();
    }

    private void OnEnable()
    {
        PlatformerSystem.OnPlayerKill.AddListener(PlayDamageSounds);
        PlatformerSystem.OnPlayerJump.AddListener(PlayJumpSound);
        PlatformerSystem.OnPlayerMove.AddListener(PlayMoveSound);
    }

    private void OnDisable()
    {
        PlatformerSystem.OnPlayerKill.RemoveListener(PlayDamageSounds);
        PlatformerSystem.OnPlayerJump.RemoveListener(PlayJumpSound);
        PlatformerSystem.OnPlayerMove.RemoveListener(PlayMoveSound);
    }
}
