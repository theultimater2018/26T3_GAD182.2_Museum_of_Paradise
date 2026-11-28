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
        if (!walkSound.isPlaying)
        {
            walkSound.Play();
        }
    }

    private void StopMoveSound()
    {
        if (walkSound.isPlaying)
        {
            walkSound.Stop();
        }
    }

    private void OnEnable()
    {
        PlatformerSystem.OnPlayerKill.AddListener(PlayDamageSounds);
        PlatformerSystem.OnPlayerJump.AddListener(PlayJumpSound);
        PlatformerSystem.OnPlayerMove.AddListener(PlayMoveSound);
        PlatformerSystem.OnPlayerStopMove.AddListener(StopMoveSound);
    }

    private void OnDisable()
    {
        PlatformerSystem.OnPlayerKill.RemoveListener(PlayDamageSounds);
        PlatformerSystem.OnPlayerJump.RemoveListener(PlayJumpSound);
        PlatformerSystem.OnPlayerMove.RemoveListener(PlayMoveSound);
        PlatformerSystem.OnPlayerStopMove.RemoveListener(StopMoveSound);
    }
}
